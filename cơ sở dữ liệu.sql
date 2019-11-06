CREATE DATABASE QuanLyQuanAnDoAn
GO
USE QuanLyQuanAnDoAn
GO


CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'	-- Trống || Có người
)
SELECT*FROM dbo.TableFood
GO      
--bảng tên account
CREATE TABLE account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'admin',
	PassWord NVARCHAR(100) NOT NULL DEFAULT 0,
	Ngaysinh NVARCHAR(100)   NULL,
	Diachi nvarchar(150) NULL,
	Gioitinh NVARCHAR(10) NULL,	
	DienThoai NVARCHAR(15) NULL,
	Type INT NOT NULL  DEFAULT 0, -- 1: admin && 0: staff
)
GO 
--bảng looại thức ăn
CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,--MÃ Thức ăn
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'--Tên thức ăn
)
GO

--bảng thức ăn
CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO
--bảng hóa đơn


CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,--mã hóa đơn
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idTable INT NOT NULL,--mã bàn chứa hóa đơn
	status INT NOT NULL DEFAULT 0, -- 1: đã thanh toán && 0: chưa thanh toán
	discount INT  DEFAULT 0,
	totalPrice float 
	
	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

--bảng hóa đơn bàn ăn
CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,--mã 
	idBill INT NOT NULL,--thuộc bill nào
	idFood INT NOT NULL,--có những thức ăn gì
	count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO
--thêm thông tin account

INSERT INTO  dbo.account VALUES  ( N'Minhnguyen',N'Nguyễn Minh Minh' ,N'Only2014'  ,N'01/1/1980',N'163/30, Thành Thái, F.14, Q.10, TPHCM',N'Nữ','0905646162',0)
INSERT INTO  dbo.account VALUES  ( N'anh2414',N'Nguyễn Như Anh' ,N'anh242014',N'12/02/1981',N'41/4, CALMETTE, Q1, TPHCM',N'Nữ','0908373612',0)
INSERT INTO  dbo.account VALUES  ( N'trang123',N'Nguyễn Minh Trang' ,N'trangminh12' ,N'04/9/1985',N'178, NAM KỲ KHỞI NGHĨA, Q4, TPHCM',N'Nữ','0908783274',0)
INSERT INTO  dbo.account VALUES  ( N'ngoc12',N'Nguyễn Như Ngọc' ,N'1232014',N'22/3/1982',N'42, Lý Thường Kiệt, Q1,1 TPHCM',N'Nữ','0135879524',0)
INSERT INTO  dbo.account VALUES  ( N'anhkhoa23',N'Nguyễn Anh Khoa',N'anhkh99',N'12/7/1990',N'383 Trần Duy Hưng, Hà Nội',N'Nam','0137955876',0)
INSERT INTO  dbo.account VALUES  ( N'thienthien12',N'Nguyễn Thiên Phúc',N'123456',N'2/1/1988',N'232, An Dương Vương,Q5,TPHCM',N'Nam','0168524654',0)
INSERT INTO  dbo.account VALUES  ( N'khangle12',N'Lê Anh Khang',N'khang12',N'02/11/1991',N'22, Tô Hiến Thành, TPHCM',N'Nam','0983254125',0)
INSERT INTO  dbo.account VALUES  ( N'ngocnhu',N'Hoàng Như Ngọc',N'ngoc231',N'09/04/1992',N'123, 3/2, Q11, TPHCM',N'Nữ','016352545',0)
INSERT INTO  dbo.account VALUES  ( N'trangle',N'Lê Anh Trang',N'tranganh123',N'07/02/1990',N'112, Lạc Long Quân, Q10,TPHCM',N'Nữ','0909099099',0)
INSERT INTO  dbo.account VALUES  ( N'giaan22',N'Hoàng Gia Ân',N'an1k23','03/02/1899',N'65 Lê Văn Sỹ, Q4,TPHCM',N'Nam','0121221221',0)               
INSERT INTO  dbo.account VALUES  ( N'admin',N'Nguyễn Đình Thiên',N'admin','12/6/1998',N'K_42.01.104.168',N'Nam','01676032595',1)      
INSERT INTO  dbo.account VALUES  ( N'tam79',N'Trần Minh Tâm',N'123456','01/09/1993',N'36, Ngô Quyền, Q11,TPHCM',N'Nam','0169545245',0)
INSERT INTO  dbo.account  VALUES  ( N'ang12',N'Lê Gia Ân',N'565758an','08/06/1994',N'30, Lãnh Binh Thăng, Q10,TPHCM',N'Nam','0165855487',0)
INSERT INTO  dbo.account VALUES  ( N'minhngoc',N'Nguyễn Ngọc Minh',N'minhngoc','05/07/1990',N'23/2, Ngô Quyền, TPHCM',N'Nữ','0169546879',0)
INSERT INTO  dbo.account VALUES  ( N'minhb12',N'Nguyễn Bảo Minh',N'minh1213','06/08/1983',N'22, Trần Hưng Đạ,o Q8,TPHCM',N'Nữ','0164256456',0)
GO


--thêm loại món ăn
INSERT dbo.FoodCategory VALUES( N'Hải sản' )
INSERT dbo.FoodCategory VALUES  ( N'Món Chay' )
INSERT dbo.FoodCategory VALUES  ( N'Món Nướng')
INSERT dbo.FoodCategory VALUES  ( N'Khai Vị' )
INSERT dbo.FoodCategory VALUES  ( N'Đồ Uống' )
INSERT dbo.FoodCategory VALUES  ( N'Món Mặn' )
INSERT dbo.FoodCategory VALUES  ( N'Món Tráng Miệng')
INSERT dbo.FoodCategory VALUES  ( N'Loại Khác')

GO

-- thêm món ăn
INSERT dbo.Food VALUES  ( N'Cá Quả Hấp Xả', 1,50000)--1
INSERT dbo.Food VALUES  ( N'Cháo Cá Chép',1,60000)--2
INSERT dbo.Food VALUES  ( N'Salad Cá Hồi',1,100000)--3
INSERT dbo.Food VALUES  ( N'Lẩu Đầu Cá Hồi Nấu Măng',1,90000)--4
INSERT dbo.Food VALUES  ( N'Tôm Hấp Bia',1,95000)--5
INSERT dbo.Food VALUES  ( N'Tôm Chiên Bột',1,55000)--6
INSERT dbo.Food VALUES  ( N'Tôm Rang Me', 1,65000)--7
INSERT dbo.Food VALUES  ( N'Nghêu Hấp Xả',1,100000)--8
INSERT dbo.Food VALUES  ( N'Gỏi Đu Đủ Chay',2,55000)--9
INSERT dbo.Food VALUES  ( N'Lá Quế Xào Ớt Với Veggie Kidney',2,70000)--10
INSERT dbo.Food VALUES  ( N'Đậu Que Xào Chay', 2, 50000)--11
INSERT dbo.Food VALUES  ( N'Tàu Hủ Sốt Nấm Đông Cô',2,56000)--12
INSERT dbo.Food VALUES  ( N'Bánh Mì Xíu Mại Chay',2,10000)
INSERT dbo.Food VALUES  ( N'Chân Gà Nướng Muối Ớt',3,45000)
INSERT dbo.Food VALUES  ( N'Vịt Quay',3,80000)
INSERT dbo.Food VALUES  ( N'Gà Nướng Mật Ong',3,95000)
INSERT dbo.Food VALUES( N'Bún Chả Cá',4,30000)
INSERT dbo.Food VALUES  ( N'StruffolI',4,46000)
INSERT dbo.Food VALUES  ( N'Bánh Xèo',4,15000)
INSERT dbo.Food VALUES  ( N'Gỏi Tai Heo',4,45000)
INSERT dbo.Food VALUES  ( N'Gỏi Xoài Tôm Chua Ngọt', 4, 65000)
INSERT dbo.Food VALUES  ( N'Canh Gà Tiềm Ngũ Quả',4,75000)
INSERT dbo.Food VALUES  ( N'Súp Cua Thập Cẩm',4,68000)

INSERT dbo.Food VALUES  ( N'Bia Heieneken',5,9000)
INSERT dbo.Food VALUES  ( N'Bia Sapporo',5,8500)
INSERT dbo.Food VALUES  ( N'Bia Tiger',5,7000)
INSERT dbo.Food VALUES  ( N'Bia Sài Gòn Special', 5, 7500)
INSERT dbo.Food VALUES  ( N'Pepsi',5,6000)
INSERT dbo.Food VALUES  ( N'Coca Cola',5,6500)
INSERT dbo.Food VALUES  ( N'Xá Xị Chương Dương', 5, 5500)
INSERT dbo.Food VALUES  ( N'Nước Suối',5,5000)
INSERT dbo.Food VALUES  ( N'Nước Tắc Sagiko',5,12000)
INSERT dbo.Food VALUES  ( N'Nước Nha Đam',5,12000)
INSERT dbo.Food VALUES  ( N'Chả Cá Lã Vọng',6,55000)
INSERT dbo.Food VALUES  ( N'Thịt Xông Khói',6,115000)
INSERT dbo.Food VALUES  ( N'Thịt Kho Cari',6,98000)
INSERT dbo.Food VALUES  ( N'Vịt Nướng Chao',6,82000)
INSERT dbo.Food VALUES  ( N'Sườn Nướng',6,87000)
INSERT dbo.Food VALUES  ( N'Bánh Flan',7,7000)
INSERT dbo.Food VALUES  ( N'Rau Câu Dừa',7,5000)
INSERT dbo.Food VALUES  ( N'Trái Cây(Dĩa)',7,30000)
INSERT dbo.Food VALUES  ( N'Kem Trứng',7,8000)


GO
--hàm ĐĂng nhập
CREATE PROC USPGetaccountByUserName
@UserName nvarchar(100)
AS 
BEGIN
	SELECT * FROM dbo.account WHERE UserName = @userName
END
GO
--vidu
EXEC dbo.USPGetaccountByUserName @UserName = N'admin' -- nvarchar(100)
GO

--tạo bảo mật đăng nhập 
--khi đúng tên and mật khẩu thì mới đăng nhập được

--khắc phục lỗi sql injection
CREATE PROC USP_login
@username NVARCHAR(100), @password NVARCHAR(100)
as
BEGIN
SELECT*FROM dbo.account WHERE UserName=@username AND PassWord =@password
END
GO
--load f co username =" ",vd "admin"
EXEC dbo.USP_login @username = N'admin', -- nvarchar(100)
    @password = N'admin' -- nvarchar(100)
	SELECT *FROM dbo.account

SELECT *FROM dbo.account WHERE UserName=''AND PassWord=''OR 5=5--cau truy vấn này bên sql có thể thực hiện được nhưng khi gọi qua vs vdpass=('or5=5--)  nhờ có hàm  USP_login nên k thực hiện đươc
GO
--Tạo danh sách bàn có 24 bàn
DECLARE @i INT = 1

WHILE @i <= 24
BEGIN
	INSERT dbo.TableFood ( name)VALUES  ( N'Bàn ' + CAST(@i AS nvarchar(100)))-- cash dùng để ép kiểu dữ liệu của @i từ int thành  
	SET @i = @i + 1
END
SELECT*FROM  dbo.TableFood
GO

--lấy bảng danh sách bàn ăn
CREATE PROC USPGetTableList
AS SELECT * FROM dbo.TableFood
GO
--update bàn 

GO
SELECT *FROM dbo.TableFood
GO

--xuất bảng account trong dtgv account
 CREATE PROC accountshow
AS 
BEGIN
	SELECT f.UserName as[Tên đăng nhập],f.DisplayName as [Tên hiển Thị],f.PassWord as [Mật khẩu],f.Ngaysinh as [Ngày Sinh],f.Diachi as [Địa Chỉ],f.Gioitinh as [Giới Tính],f.DienThoai as [Điện Thoại],f.Type as [Loại]
	FROM  dbo.account f
END
EXEC dbo.accountshow--câu truy vấn
GO
--xuất băng thức ăn

CREATE PROC foodShow
AS 
BEGIN
	SELECT f.id as[Số Thứ Tự],f.name as[Tên Món Ăn],f.idCategory as[Loại],f.price as[Giá]

	FROM dbo.Food f
END
EXEC dbo.foodShow--câu truy vấn để lấy danh sách món ăn
GO

--thêm bill

-- DateCheckIn DateCheckOut ,idTable ,status 


--billinfo.id =bill.id và billinfo.foodid=food.id và bill.tableid="x"
--Lấy tất cả thông tin có liên quan đến bill với bill.tableid="X"

--lọc thông tin cần xuất trong TABLEquanli(totalprice=prive*count, count, price,name)
SELECT f.name,bi.count,f.price,f.price*bi.count AS totalprice FROM dbo.BillInfo AS bi,bill AS b,dbo.Food AS f
WHERE bi.idBill=b.id AND bi.idFood= f.id AND b.status=0 AND  b.idTable=2;
GO
SELECT*FROM dbo.TableFood
SELECT*FROM dbo.BillInfo
SELECT*FROM dbo.Bill
select*from FoodCategory
select*from dbo.Food where idCategory=5
--insert bill mới
GO 

CREATE PROC USPInsertBill
@idTable int
AS 
BEGIN
	INSERT dbo.Bill VALUES  ( GETDATE() , NULL , @idTable , 0, 0,NULL)
END
GO


--lấy id lớn nhất của bill 
SELECT MAX (id) FROM dbo.Bill
--
GO
SELECT MAX (id) FROM dbo.TableFood
GO 
SELECT*FROM dbo.TableFood
GO 
--trường hợp bill đã tồn tạ
CREATE PROC USPInsertBillInfo
	@idBill INT , @idFood INT , @count INT
	AS
	BEGIN
		DECLARE @isExitsBillInfo INT
		DECLARE @foodCount INT = 1
	
		SELECT @isExitsBillInfo = id , @foodCount = b.count 
		FROM dbo.BillInfo AS b 
		WHERE idBill = @idBill AND idFood = @idFood

		IF (@isExitsBillInfo > 0)
			BEGIN
				DECLARE @newCount INT = @foodCount + @count
				IF (@newCount > 0)
					UPDATE dbo.BillInfo	SET count = @foodCount + @count WHERE idFood = @idFood
				ELSE
					DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
			 END
		ELSE
		BEGIN
			INSERT	dbo.BillInfo( idBill , idFood, count )
			VALUES  ( @idBill , @idFood , @count )
		END
END
GO

--update status trong va set thuoc tinh khi da thanh toan
--updatebill 
UPDATE dbo.Bill SET status =1 WHERE id=1;
SELECT*FROM dbo.TableFood SELECT* FROM dbo.BillInfo
GO

--nếu opdate cho bill info sẽ cập nhật status thành có người

CREATE TRIGGER UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = idBill FROM Inserted
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0	
	
	DECLARE @count INT
	SELECT @count = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idBill
	
	IF (@count > 0)
	BEGIN
	
		PRINT @idTable
		PRINT @idBill
		PRINT @count
		
		UPDATE dbo.TableFood SET status = N'Có người' WHERE id = @idTable		
		
	END		
	ELSE
	BEGIN
	PRINT @idTable
		PRINT @idBill
		PRINT @count
	UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable	
	end
	
END
GO
SELECT*FROM dbo.account
--update cho
 --bill để cập nhật thông tin là trống
GO 
CREATE TRIGGER UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = id FROM Inserted	--lấy đưowjc idtable
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill --lấy được idbill qua idtable
	
	DECLARE @count int = 0
	
	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0--đếm số lượng table mà có status==0 trong table
	
	IF (@count = 0)--nếu số lượng table mà có status==0 =0 nghĩa là k có bill chưa thanh toán thì update là trống
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END 
GO 

SELECT*FROM dbo.food
SELECT*FROM dbo.BillInfo
SELECT*FROM dbo.TableFood
GO 
--truy vấn xuất trong doanh thu
CREATE PROC USPGetListBill
		@CheckIn DATE,
		@CheckOut DATE
	AS
		BEGIN
			SELECT t.name AS N'Tên bàn' , b.DateCheckIn AS N'Ngày vào',b.DateCheckOut AS N'Ngày ra',b.discount AS N'Giảm giá %',b.totalPrice AS N'Tổng Tiền(Đơn Vị:Nghìn đồng)'
			FROM dbo.Bill AS b,dbo.TableFood AS t
			WHERE b.DateCheckIn>=@CheckIn AND b.DateCheckOut<=@CheckOut AND b.status=1 AND t.id=b.idTable
		END
	GO
EXEC dbo.USPGetListBill @CheckIn = '2017-10-09 14:42:44', -- date
    @CheckOut = '2017-12-09 14:42:44' -- date
GO

--chức năng đổi mật khẩu or thông tin
CREATE PROC USPUpdateAccount
@useName NVARCHAR(50),@displayName NVARCHAR(24),@diaChi NVARCHAR(100) ,@newPass NVARCHAR(24),@pass NVARCHAR(24),@gioiTinh NVARCHAR(10),@dienThoai NVARCHAR(18)
AS
BEGIN
		DECLARE @isPassTrue INT = 0 
		SELECT @isPassTrue  =COUNT(*) FROM dbo.account WHERE UserName=@useName AND PassWord=@pass
		IF(@isPassTrue=1)
		BEGIN
			IF(@newPass=NULL OR @newPass=' ')
			BEGIN
            UPDATE dbo.account SET DisplayName =@displayName, Diachi=@diaChi ,Gioitinh=@gioiTinh,DienThoai=@dienThoai  WHERE UserName=@useName
			END
           ELSE 
		   UPDATE dbo.account SET DisplayName=@displayName, PassWord=@newPass, Diachi=@diaChi ,Gioitinh=@gioiTinh,DienThoai=@dienThoai   WHERE UserName=@useName
        END       
END
GO
SELECT*FROM dbo.account

GO
-- update status thành trống ở bàn ăn nếu trong bill info chưa thanh toán có món ăn đã bị xóa
CREATE TRIGGER USP_DeleteBillInfo
ON dbo.BillInfo FOR DELETE--thao tác thực hiện từ việc xóa billinfo
AS 
BEGIN
	DECLARE @idBillInfo INT--biến để lưu giá trị idbillinfo
	DECLARE @idBill INT--biến để lưu giá trị idbill
	SELECT @idBillInfo = id/*id = idbillinfo của billinfo vừa xóa*/, @idBill = Deleted.idBill FROM Deleted/*@idbill = idbill của billinfo vừa xóa*/
	
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill--lấy ra idtable từ @idbill(từ billinfo vừa xóa)
	
	DECLARE @count INT = 0
	--nếu table có số bill chưa thanh toán =0(nghĩa là đếm số lượng bill chưa checkout =0)-->đã thanh toán hết rồi
	SELECT @count = COUNT(*) FROM dbo.BillInfo AS bi, dbo.Bill AS b WHERE b.id = bi.idBill AND b.id = @idBill AND b.status = 0
	--set lại status là trống_(0) vì không còn bill nào chưa thanh toán cả
	IF (@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO
SELECT * FROM dbo.Food WHERE name = N'Nước Suối'
GO 
-- đổi tất cả kí tự có dấu thành không dấu
--tên hàm là fuConvertToUnsign1
--để truy vấn hàm SELECT *FROM (table cần truy vấn) WHERE dbo.fuConvertToUnsign1(Tên Cột Cần Tìm) LIKE N'%'+ dbo.fuConvertToUnsign1(N'(Tìm chữ Gì:)')+'%'
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) )
 RETURNS NVARCHAR(4000) 
 AS 
 BEGIN 
	 IF @strInput IS NULL 
		 RETURN @strInput 
	 IF @strInput = ''
		 RETURN @strInput 
	 DECLARE @RT NVARCHAR(4000)
	 DECLARE @SIGN_CHARS NCHAR(136) 
	 DECLARE @UNSIGN_CHARS NCHAR (136) 
	 SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)
	 + NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'
	 DECLARE @COUNTER
	 INT DECLARE @COUNTER1
	 INT	SET @COUNTER = 1 
			WHILE (@COUNTER <=LEN(@strInput))
			BEGIN 
					SET  @COUNTER1 = 1 
			WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
				 BEGIN 
					 IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
							 BEGIN
								IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
							 ELSE 
								SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER)
								BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-')
RETURN @strInput END
 
 GO
 --truy vấn 
 SELECT UserName,DisplayName  FROM dbo.account WHERE dbo.fuConvertToUnsign1(UserName) LIKE N'%'+ dbo.fuConvertToUnsign1(N'minh')+'%'
GO
GO

  SELECT*FROM dbo.account
  SELECT UserName,DisplayName,PassWord,Diachi,Ngaysinh, Gioitinh, DienThoai FROM dbo.account WHERE dbo.fuConvertToUnsign1(UserName) LIKE N'%'+ dbo.fuConvertToUnsign1(N'{ngoc}')+'%'
  SELECT UserName,DisplayName,PassWord,Diachi,Ngaysinh, Gioitinh, DienThoai FROM dbo.account WHERE dbo.fuConvertToUnsign1(UserName) LIKE N'%'+ dbo.fuConvertToUnsign1(N'minh')+'%'



 
