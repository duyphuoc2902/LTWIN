﻿CREATE DATABASE RESTAURANT 
GO
USE RESTAURANT
GO 

CREATE TABLE BAN_AN 
(
	ID INT IDENTITY PRIMARY KEY,
	TEN NVARCHAR(50) NOT NULL, 
	TRANGTHAI NVARCHAR(100) NOT NULL DEFAULT N'Trống',
	TRANGTHAI2 INT DEFAULT 0
)
GO

CREATE TABLE ORDERED_TABLE(
	ORDER_ID INT IDENTITY(1,1) PRIMARY KEY,
	TABLE_ID INT,
	ORDERS_NAME NVARCHAR(50),
	Number VARCHAR(10),
	ORDER_TIME DATETIME
)
GO

CREATE TABLE ACCOUNT 
(
	USERNAME NVARCHAR(100) PRIMARY KEY,
	DISPLAYNAME NVARCHAR(100) NOT NULL,
	PASS NVARCHAR(1000) NOT NULL DEFAULT 0,
	TYPE INT NOT NULL DEFAULT 1
)
GO 
CREATE TABLE CATEGORY
(
	ID INT IDENTITY PRIMARY KEY,
	NAME NVARCHAR(100) NOT NULL 
)

GO 
CREATE TABLE FOOD 
(
	ID INT IDENTITY PRIMARY KEY,
	NAME NVARCHAR(100) NOT NULL,
	ID_CAT INT NOT NULL,
	PRICE FLOAT NOT NULL DEFAULT 0

	FOREIGN KEY (ID_CAT) REFERENCES CATEGORY(ID)
)

GO
CREATE TABLE BILL
(
	ID INT IDENTITY PRIMARY KEY,
	DATECHECKIN DATE NOT NULL DEFAULT GETDATE(),
	DATECHECKOUT DATE,
	ID_TABLE INT NOT NULL,
	STATUS INT NOT NULL DEFAULT 0 

	FOREIGN KEY (ID_TABLE) REFERENCES BAN_AN(ID)
)
GO
CREATE TABLE BILLDETAIL 
(
	ID INT IDENTITY PRIMARY KEY,
	ID_BILL INT NOT NULL,
	ID_FOOD INT NOT NULL,
	COUNT INT NOT NULL DEFAULT 0

	FOREIGN KEY (ID_BILL) REFERENCES BILL(ID),
	FOREIGN KEY (ID_FOOD) REFERENCES FOOD(ID)
)
GO

INSERT INTO [dbo].[ACCOUNT](USERNAME, DISPLAYNAME, PASS, TYPE)
VALUES 
(N'ADMIN', N'VU', N'1', 1),
(N'STAFF', N'STAFF1', N'1', 0)
GO

CREATE PROC GETACCOUNT
@username NVARCHAR(100)
AS
BEGIN
	SELECT * FROM ACCOUNT
	WHERE USERNAME = @username
END 
GO 
EXEC dbo.GETACCOUNT @username = N'STAFF'
GO

CREATE PROC LOG_IN
@username NVARCHAR(100),
@pass NVARCHAR(100)
AS
BEGIN
	SELECT *FROM ACCOUNT 
	WHERE USERNAME = @username AND PASS = @pass
END
GO

INSERT INTO BAN_AN (TEN)
VALUES 
(N'Bàn 1'),
(N'Bàn 2'),
(N'Bàn 3'),
(N'Bàn 4'),
(N'Bàn 5'),
(N'Bàn 6'),
(N'Bàn 7'),
(N'Bàn 8')
GO


CREATE PROC GETTABLELIST
AS 
SELECT ID, TEN, TRANGTHAI, TRANGTHAI2 FROM [dbo].[BAN_AN]
GO


INSERT INTO [dbo].[CATEGORY] (NAME)
VALUES
(N'Súp'),
(N'Lẩu'),
(N'Nướng'),
(N'Món chính'),
(N'Giải khát')
GO

INSERT INTO [dbo].[FOOD] (ID_CAT, NAME, PRICE)
VALUES
(1, N'Súp măng tây hải sản', 40000),
(1, N'Súp cua', 40000),
(1, N'Súp hải sản', 45000),
(1, N'Súp bào ngư', 60000),
(1, N'Súp tổ yến', 150000),
(2, N'Lẩu thái', 250000),
(2, N'Lẩu cá thác lác', 255000),
(2, N'Lẩu lươn', 260000),
(2, N'Lẩu cá bớp', 280000),
(2, N'Lẩu tứ xuyên', 300000),
(3, N'Ba chỉ bò Mỹ', 75000),
(3, N'Ba chỉ cuộn nấm', 75000),
(3, N'Tôm nướng muối ớt', 79000),
(3, N'Bạch tuộc nướng', 69000),
(3, N'Cánh gà nướng', 69000),
(4, N'Cơm chiên muối ớt', 50000),
(4, N'Cơm chiên cá mặn', 79000),
(4, N'Cơm chiên bò', 120000),
(4, N'Cơm chiên hải sản', 175000),
(5, N'Nước ngọt các loại', 10000),
(5, N'Nước suối', 5000),
(5, N'Bia Tiger', 12000)
GO

INSERT INTO [dbo].[BILL] (DATECHECKIN, DATECHECKOUT, ID_TABLE, STATUS)
VALUES 
(GETDATE(), NULL, 2, 0),
(GETDATE(), GETDATE(), 5, 1)
GO

INSERT INTO [dbo].[BILLDETAIL] (ID_BILL, ID_FOOD, COUNT)
VALUES 
(1, 2, 2),
(2, 2, 1)
GO

CREATE PROC INSERTBILL
@idtable INT 
AS
BEGIN
	INSERT INTO BILL (DATECHECKIN, DATECHECKOUT, ID_TABLE, STATUS)
	VALUES 
	(GETDATE(), NULL, @idtable, 0)
END
GO

CREATE PROC INSERTBILLDETAIL
@idbill INT, 
@idfood INT, 
@count INT 
AS
BEGIN
	INSERT INTO BILLDETAIL (ID_BILL, ID_FOOD, COUNT)
	VALUES 
	(@idbill, @idfood, @count)
END
GO

ALTER PROC INSERTBILLDETAIL
@idbill INT, 
@idfood INT, 
@count INT 
AS
BEGIN
	DECLARE @existbilldetail INT
	DECLARE @foodcount INT = 1
	SELECT @existbilldetail = ID, @foodcount = count FROM BILLDETAIL WHERE ID_BILL = @idbill AND ID_FOOD = @idfood
	IF (@existbilldetail > 0)
	BEGIN
		DECLARE @newcount INT = @foodcount + @count 
		IF (@newcount > 0)
		UPDATE BILLDETAIL SET COUNT = @foodcount + @count
		WHERE ID_FOOD = @idfood
		ELSE 
		DELETE BILLDETAIL WHERE ID_BILL = @idbill AND ID_FOOD = @idfood
	END 
	ELSE 
	BEGIN
		INSERT INTO BILLDETAIL (ID_BILL, ID_FOOD, COUNT)
		VALUES 
		(@idbill, @idfood, @count)
	END
END
GO

CREATE TRIGGER UPDATEBILLDETAIL
ON BILLDETAIL FOR INSERT, UPDATE 
AS
BEGIN
	DECLARE @idbill INT 
	SELECT @idbill = ID_BILL FROM INSERTED
	
	DECLARE @idtable INT
	SELECT @idtable = ID_TABLE FROM BILL WHERE ID = @idbill AND STATUS = 0
	
END
GO

CREATE TRIGGER UPDATEBILL
ON BILL FOR UPDATE 
AS
BEGIN
	DECLARE @idbill INT 
	SELECT @idbill = ID FROM INSERTED 

	DECLARE @idtable INT
	SELECT @idtable = ID_TABLE FROM BILL WHERE ID = @idbill 

	DECLARE @count INT = 0
	SELECT @count = COUNT(*) FROM BILL WHERE ID_TABLE = @idtable AND STATUS = 0

	IF (@count = 0) 
	UPDATE BAN_AN SET TRANGTHAI = N'Trống'
	WHERE ID = @idtable
END 
GO

ALTER TABLE BILL 
ADD TOTALPRICE FLOAT

GO

CREATE PROC GETLISTBILLBYDATE 
@checkin date, 
@checkout date
AS
BEGIN
	SELECT BAN_AN.TEN AS [Bàn], BILL.TOTALPRICE AS [Tổng đơn], DATECHECKIN AS [Ngày lên đơn], DATECHECKOUT AS [Ngày thanh toán]
	FROM BILL, BAN_AN
	WHERE DATECHECKIN >= @checkin AND DATECHECKOUT <= @checkout AND BILL.STATUS = 1 AND BAN_AN.ID = BILL.ID_TABLE
END 
GO

CREATE PROC CHANGETABLE
@old_id int,
@new_id int
AS
BEGIN
	UPDATE BILL
	SET ID_TABLE = @new_id
	WHERE ID_TABLE = @old_id

	UPDATE BAN_AN
	SET TRANGTHAI = N'Trống'
	WHERE ID = @old_id

	UPDATE BAN_AN
	SET TRANGTHAI = N'Có Người'
	WHERE ID = @new_id
END

GO

CREATE PROC DELETE_BILL_UNSAVED
@id_bill int
AS
BEGIN
	DELETE FROM BILLDETAIL
	WHERE ID_BILL = @id_bill

	DELETE FROM BILL
	WHERE ID = @id_bill
END

GO

CREATE PROC UPDATEACCOUNT
@username NVARCHAR(100),
@displayname NVARCHAR(100),
@pass NVARCHAR(100),
@newpass NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightpass INT 
	SELECT @isRightpass = COUNT(*) FROM ACCOUNT WHERE USERNAME = @username AND PASS = @pass
	
	IF (@isRightpass = 1)
	BEGIN
		IF (@newpass = NULL OR @newpass = '')
		BEGIN 
			UPDATE ACCOUNT SET DISPLAYNAME = @displayname WHERE USERNAME = @username
		END
		ELSE 
			UPDATE ACCOUNT SET DISPLAYNAME = @displayname, PASS = @newpass WHERE USERNAME = @username  
	END
END
GO

CREATE TRIGGER DELETEBILLDETAIL
ON BILLDETAIL FOR DELETE 
AS
BEGIN
	DECLARE @idbilldetail INT 
	DECLARE @idbill INT
	SELECT @idbilldetail = ID, @idbill = deleted.ID_BILL FROM deleted

	DECLARE @idtable INT 
	SELECT @idtable = ID_TABLE 
	FROM BILL 
	WHERE ID = @idbill

	DECLARE @count INT = 0
	SELECT @count = COUNT(*) 
	FROM BILLDETAIL, BILL 
	WHERE ID_BILL = @idbill AND BILL.ID = BILLDETAIL.ID_BILL AND BILL.ID = @idbill AND BILL.STATUS = 0
	IF (@count = 0)
		UPDATE BAN_AN SET TRANGTHAI = N'Trống' WHERE ID = @idtable
	 
END
GO


CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) 
AS 
BEGIN 
IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput 
DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) 
DECLARE @UNSIGN_CHARS NCHAR (136) 
SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) 
SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
DECLARE @COUNTER int 
DECLARE @COUNTER1 int SET @COUNTER = 1 
WHILE (@COUNTER <=LEN(@strInput)) 
BEGIN 
SET @COUNTER1 = 1 
WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
BEGIN 
IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
BEGIN 
IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
ELSE 
SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) 
BREAK 
END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput 
END

GO

CREATE PROC INSERTTABLE_NONAME
AS
BEGIN
	DECLARE @id int
	SELECT @id = MAX(ID) + 1
	FROM BAN_AN
	INSERT INTO BAN_AN(TEN)
		VALUES(N'Bàn ' + CAST(@id as varchar(10)))
END
GO

CREATE PROC DELETETABLE
@id int
AS
BEGIN
	DELETE FROM BAN_AN
	WHERE ID = @id;
END

GO

CREATE PROC UPDATETABLE
@id int,
@name nvarchar(50),
@trangthai nvarchar(50)
AS
BEGIN
	UPDATE BAN_AN
	SET TEN = @name, TRANGTHAI = @trangthai
	WHERE ID = @id
END
GO

CREATE PROC INSERTTABLE_MANY
@count int
AS
BEGIN
	WHILE @count > 0
		BEGIN
			EXEC INSERTTABLE_NONAME
			SET @count = @count - 1
		END
END
GO

CREATE PROC SET_ORDERED
@id_table int
AS
BEGIN
	UPDATE BAN_AN
	SET TRANGTHAI2 = 1
	WHERE ID = @id_table
END
GO


CREATE TRIGGER INSERT_ORDER
ON ORDERED_TABLE
AFTER Insert
AS
BEGIN
	DECLARE @order_id INT, @table_id INT
	SELECT @order_id = inserted.ORDER_ID, @table_id = TABLE_ID
	FROM inserted
	UPDATE BAN_AN
	SET TRANGTHAI2 = @order_id
	WHERE ID = @table_id
END
GO

CREATE PROC INSERT_ORDERED
@id_table INT,
@order_name NVARCHAR(50),
@number VARCHAR(10),
@order_date DATETIME
AS
	BEGIN
		INSERT INTO ORDERED_TABLE(TABLE_ID, ORDERS_NAME, Number, ORDER_TIME)
			VALUES(@id_table, @order_name, @number, @order_date)
	END
GO

CREATE PROC GET_ORDERED_TABLE
@table_id INT
AS
BEGIN
	SELECT TOP 1 * 
	FROM ORDERED_TABLE
	WHERE TABLE_ID = @table_id AND ORDER_TIME > GETDATE()
	ORDER BY ORDER_ID DESC, ORDER_TIME ASC
END
GO

CREATE TRIGGER INSERT_ORDEREDTABLE
ON ORDERED_TABLE
AFTER INSERT
AS
	BEGIN
		DECLARE @date DATETIME
		SELECT @date = ORDER_TIME
		FROM inserted
		IF(@date < GETDATE())
			ROLLBACK TRAN
	END
GO

CREATE PROC THEMMONAN
@NAME NVARCHAR(100),
@ID_CAT INT,
@PRICE FLOAT
AS
BEGIN
	DECLARE @CHECK INT
	SET @CHECK = (SELECT COUNT(NAME) FROM FOOD WHERE NAME = @NAME)
	IF (@CHECK = 0)
		BEGIN
			INSERT INTO FOOD VALUES(@NAME, @ID_CAT, @PRICE)
			SELECT 1
		END
	ELSE
		BEGIN
			SELECT 0
		END
END
GO