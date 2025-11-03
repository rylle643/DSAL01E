CREATE DATABASE POS_Database_V2;
GO

USE POS_Database_V2;
GO

-- ================================================================
-- SECTION 1: CREATE TABLES
-- ================================================================

-- Table 1: employeeTbl (Create first as it's referenced by foreign keys)
CREATE TABLE employeeTbl (
    emp_id VARCHAR(50) PRIMARY KEY,
    emp_fname VARCHAR(100),
    emp_surname VARCHAR(100),
    terminal_no VARCHAR(50)
);
GO

-- Table 2: useraccountTbl
CREATE TABLE useraccountTbl (
    account_id INT PRIMARY KEY IDENTITY(1,1),
    emp_id VARCHAR(50) NOT NULL,
    username NVARCHAR(50) NOT NULL,
    password NVARCHAR(100) NOT NULL,
    FOREIGN KEY (emp_id) REFERENCES employeeTbl(emp_id)
);
GO

-- Table 3: pos_nameTbl (Stores product names)
CREATE TABLE pos_nameTbl (
    id INT PRIMARY KEY IDENTITY(1,1),
    pos_id VARCHAR(50) NOT NULL UNIQUE,
    name1 VARCHAR(100),
    name2 VARCHAR(100),
    name3 VARCHAR(100),
    name4 VARCHAR(100),
    name5 VARCHAR(100),
    name6 VARCHAR(100),
    name7 VARCHAR(100),
    name8 VARCHAR(100),
    name9 VARCHAR(100),
    name10 VARCHAR(100),
    name11 VARCHAR(100),
    name12 VARCHAR(100),
    name13 VARCHAR(100),
    name14 VARCHAR(100),
    name15 VARCHAR(100),
    name16 VARCHAR(100),
    name17 VARCHAR(100),
    name18 VARCHAR(100),
    name19 VARCHAR(100),
    name20 VARCHAR(100)
);
GO

-- Table 4: pos_priceTbl (Stores product prices)
CREATE TABLE pos_priceTbl (
    id INT PRIMARY KEY IDENTITY(1,1),
    pos_id VARCHAR(50) NOT NULL,
    price1 DECIMAL(10,2),
    price2 DECIMAL(10,2),
    price3 DECIMAL(10,2),
    price4 DECIMAL(10,2),
    price5 DECIMAL(10,2),
    price6 DECIMAL(10,2),
    price7 DECIMAL(10,2),
    price8 DECIMAL(10,2),
    price9 DECIMAL(10,2),
    price10 DECIMAL(10,2),
    price11 DECIMAL(10,2),
    price12 DECIMAL(10,2),
    price13 DECIMAL(10,2),
    price14 DECIMAL(10,2),
    price15 DECIMAL(10,2),
    price16 DECIMAL(10,2),
    price17 DECIMAL(10,2),
    price18 DECIMAL(10,2),
    price19 DECIMAL(10,2),
    price20 DECIMAL(10,2)
);
GO

-- Table 5: pos_picTbl (Stores picture paths)
CREATE TABLE pos_picTbl (
    id INT PRIMARY KEY IDENTITY(1,1),
    pos_id VARCHAR(50) NOT NULL,
    pic1 VARCHAR(500),
    pic2 VARCHAR(500),
    pic3 VARCHAR(500),
    pic4 VARCHAR(500),
    pic5 VARCHAR(500),
    pic6 VARCHAR(500),
    pic7 VARCHAR(500),
    pic8 VARCHAR(500),
    pic9 VARCHAR(500),
    pic10 VARCHAR(500),
    pic11 VARCHAR(500),
    pic12 VARCHAR(500),
    pic13 VARCHAR(500),
    pic14 VARCHAR(500),
    pic15 VARCHAR(500),
    pic16 VARCHAR(500),
    pic17 VARCHAR(500),
    pic18 VARCHAR(500),
    pic19 VARCHAR(500),
    pic20 VARCHAR(500)
);
GO

-- Table 6: salesTbl (stores sales transactions)
CREATE TABLE salesTbl (
    sales_id INT IDENTITY(1,1) PRIMARY KEY,
    product_name VARCHAR(100),
    product_quantity_per_transaction INT,
    product_price DECIMAL(10,2),
    discount_option VARCHAR(50),
    discount_amount_per_transaction DECIMAL(10,2),
    discounted_amount_per_transaction DECIMAL(10,2),
    summary_total_quantity INT,
    summary_total_disc_given DECIMAL(10,2),
    summary_total_discounted_amount DECIMAL(10,2),
    terminal_no VARCHAR(50),
    time_date VARCHAR(100),
    emp_id VARCHAR(50),
    FOREIGN KEY (emp_id) REFERENCES employeeTbl(emp_id)
);
GO

-- ================================================================
-- SECTION 2: ALTER TABLES
-- ================================================================

-- Add account_type column to employeeTbl
ALTER TABLE employeeTbl
ADD account_type VARCHAR(50);
GO

-- Add Foreign Key Constraints (optional but recommended)
ALTER TABLE pos_priceTbl 
ADD CONSTRAINT FK_Price_Name FOREIGN KEY (pos_id) REFERENCES pos_nameTbl(pos_id);
GO

ALTER TABLE pos_picTbl 
ADD CONSTRAINT FK_Pic_Name FOREIGN KEY (pos_id) REFERENCES pos_nameTbl(pos_id);
GO

-- ================================================================
-- SECTION 3: CREATE INDEXES
-- ================================================================

-- Create Indexes for better performance
CREATE INDEX IX_pos_nameTbl_pos_id ON pos_nameTbl(pos_id);
CREATE INDEX IX_pos_priceTbl_pos_id ON pos_priceTbl(pos_id);
CREATE INDEX IX_pos_picTbl_pos_id ON pos_picTbl(pos_id);
GO

-- ================================================================
-- SECTION 4: INSERT SAMPLE DATA
-- ================================================================

-- Insert sample employees
INSERT INTO employeeTbl (emp_id, emp_fname, emp_surname, terminal_no) 
VALUES ('123', 'John', 'Doe', 'Terminal 1'), ('456', 'Jo', 'Dela Cruz', 'Terminal 2'), ('789', 'Jack', 'Delima', 'Terminal 3'), ('101', 'Jane', 'Deguzman', 'Terminal 4'), ('112', 'James', 'Deontology', 'Terminal 5');
GO

-- Update existing employees with account types
UPDATE employeeTbl
SET account_type = 'Administrator'
WHERE emp_id = '123';

UPDATE employeeTbl
SET account_type = 'Cashier'
WHERE emp_id = '456';

UPDATE employeeTbl
SET account_type = 'Cashier'
WHERE emp_id = '789';

UPDATE employeeTbl
SET account_type = 'Cashier'
WHERE emp_id = '101';

UPDATE employeeTbl
SET account_type = 'Cashier'
WHERE emp_id = '112';
GO

-- Insert sample user accounts
INSERT INTO useraccountTbl (emp_id, username, password)
VALUES ('123', 'admin', 'admin123');

INSERT INTO useraccountTbl (emp_id, username, password)
VALUES ('456', 'cashier1', 'pass123');

INSERT INTO useraccountTbl (emp_id, username, password)
VALUES ('789', 'cashier2', 'pass123');
GO

-- Insert product names
SET IDENTITY_INSERT [dbo].[pos_nameTbl] ON;
GO

INSERT [dbo].[pos_nameTbl] ([id], [pos_id], [name1], [name2], [name3], [name4], [name5], [name6], [name7], [name8], [name9], [name10], [name11], [name12], [name13], [name14], [name15], [name16], [name17], [name18], [name19], [name20]) 
VALUES (2, N'123', N'VERSACE EROS EDT FOR MEN', N'BURBERRY BRIT SHEER EDT FOR WOMEN', N'DAVIDOFF COOL WATER EDT FOR MEN', N'HUGO BOSS THE SCENT EDT FOR MEN', N'DOLCE & GABBANA D&G LIGHT BLUE EDT FOR WOMEN', N'CALVIN KLEIN CK ETERNITY EDP FOR WOMEN', N'ISSEY MIYAKE L''EAU D''ISSEY POUR HOMME EDT FOR MEN', N'CALVIN KLEIN CK ONE EDT UNISEX', N'JIMMY CHOO EDP FOR WOMEN', N'VERSACE BRIGHT CRYSTAL EDT FOR WOMEN', N'DAVIDOFF COOL WATER EDT FOR WOMEN', N'CREED AVENTUS EDP FOR MEN', N'SALVATORE FERRAGAMO INCANTO SHINE EDT FOR WOMEN', N'VIKTOR & ROLF FLOWERBOMB EDP FOR WOMEN', N'CHLOE EDP FOR WOMEN', N'VERSACE BRIGHT CRYSTAL ABSOLU EDP FOR WOMEN', N'VERSACE MAN EAU FRAICHE EDT FOR MEN', N'VERSACE POUR HOMME EDT FOR MEN', N'BVLGARI MAN EXTREME EDT FOR MEN', N'LANCOME LA VIE EST BELLE EDP FOR WOMEN');

INSERT [dbo].[pos_nameTbl] ([id], [pos_id], [name1], [name2], [name3], [name4], [name5], [name6], [name7], [name8], [name9], [name10], [name11], [name12], [name13], [name14], [name15], [name16], [name17], [name18], [name19], [name20]) 
VALUES (6, N'333', N'Cricut EasyPress Mini, Zen Blue', N'Sony PlayStation 5 Slim', N'Apple iPhone 13', N'Acer Nitro V ANV15-41-R2M0 Black', N'Cricut EasyPress 3', N'Anker Zolo Charger Pink', N'ZAGG Crystal Palace iPhone 16 Pro Clear Case', N'UGREEN Smart Bluetooth Finder CM520/60387', N'Cricut Mug Press', N'Huawei Band 10 Black', N'HP Smart Tank 580 1F3Y2A', N'TECNO Camon 40 Pro 5G (12GB + 256GB) Glacier White', N'Insta360 X4 Standard Bundle', N'Apple iPad Air 13-inch (7th Gen) Wi-Fi', N'UGREEN PB311 10000mAh 20W Power Bank', N'GoPro HERO', N'Huawei MateBook D16 MCLF-W5651 Silver', N'Nintendo Switch OLED Neon Blue/Neon Red', N'Apple Pencil Pro', N'Apple AirPods 4 with Active Noise Cancellation');

INSERT [dbo].[pos_nameTbl] ([id], [pos_id], [name1], [name2], [name3], [name4], [name5], [name6], [name7], [name8], [name9], [name10], [name11], [name12], [name13], [name14], [name15], [name16], [name17], [name18], [name19], [name20]) 
VALUES (7, N'111', N'M.Y. San Skyflakes Crackers', N'Hermano Refined Sugar', N'Knorr Beef Broth Cubes', N'Knorr Chicken Broth Cubes', N'Knorr Sinigang Original', N'Cowhead Pure Milk', N'VCut Potato Chips Spicy Barbeque Flavor', N'Century Tuna Flakes in Vegetable Oil', N'Datu Puti Vinegar', N'Gardenia Classic White Bread', N'Yakult Probiotic Drink', N'Spam Lite Luncheon Meat', N'Bread Pan Cheese & Onion Toasted Bread', N'Sinigang sa Sampalok na may Gabi', N'Hermano Brown Sugar', N'Argentina Beef Tapa', N'Jolly Finger Cream Sandwich Cookies', N'Fibisco Choco Mallows Biscuits', N'Absolute Pure Distilled Drinking Water', N'Marby Spanish Bread');

SET IDENTITY_INSERT [dbo].[pos_nameTbl] OFF;
GO

-- Insert product prices
SET IDENTITY_INSERT [dbo].[pos_priceTbl] ON;
GO

INSERT [dbo].[pos_priceTbl] ([id], [pos_id], [price1], [price2], [price3], [price4], [price5], [price6], [price7], [price8], [price9], [price10], [price11], [price12], [price13], [price14], [price15], [price16], [price17], [price18], [price19], [price20]) 
VALUES (2, N'123', CAST(5999.00 AS Decimal(10, 2)), CAST(3399.00 AS Decimal(10, 2)), CAST(3599.00 AS Decimal(10, 2)), CAST(5999.00 AS Decimal(10, 2)), CAST(4999.00 AS Decimal(10, 2)), CAST(3399.00 AS Decimal(10, 2)), CAST(4699.00 AS Decimal(10, 2)), CAST(2999.00 AS Decimal(10, 2)), CAST(5399.00 AS Decimal(10, 2)), CAST(5499.00 AS Decimal(10, 2)), CAST(2999.00 AS Decimal(10, 2)), CAST(23999.00 AS Decimal(10, 2)), CAST(3999.00 AS Decimal(10, 2)), CAST(9999.00 AS Decimal(10, 2)), CAST(6699.00 AS Decimal(10, 2)), CAST(5999.00 AS Decimal(10, 2)), CAST(4999.00 AS Decimal(10, 2)), CAST(4999.00 AS Decimal(10, 2)), CAST(8999.00 AS Decimal(10, 2)), CAST(7999.00 AS Decimal(10, 2)));

INSERT [dbo].[pos_priceTbl] ([id], [pos_id], [price1], [price2], [price3], [price4], [price5], [price6], [price7], [price8], [price9], [price10], [price11], [price12], [price13], [price14], [price15], [price16], [price17], [price18], [price19], [price20]) 
VALUES (6, N'333', CAST(2699.00 AS Decimal(10, 2)), CAST(30790.00 AS Decimal(10, 2)), CAST(25990.00 AS Decimal(10, 2)), CAST(43499.00 AS Decimal(10, 2)), CAST(7999.00 AS Decimal(10, 2)), CAST(575.00 AS Decimal(10, 2)), CAST(1090.00 AS Decimal(10, 2)), CAST(949.00 AS Decimal(10, 2)), CAST(9999.00 AS Decimal(10, 2)), CAST(2099.00 AS Decimal(10, 2)), CAST(8995.00 AS Decimal(10, 2)), CAST(14999.00 AS Decimal(10, 2)), CAST(25890.00 AS Decimal(10, 2)), CAST(75990.00 AS Decimal(10, 2)), CAST(999.00 AS Decimal(10, 2)), CAST(9990.00 AS Decimal(10, 2)), CAST(30999.00 AS Decimal(10, 2)), CAST(16990.00 AS Decimal(10, 2)), CAST(9290.00 AS Decimal(10, 2)), CAST(10490.00 AS Decimal(10, 2)));

INSERT [dbo].[pos_priceTbl] ([id], [pos_id], [price1], [price2], [price3], [price4], [price5], [price6], [price7], [price8], [price9], [price10], [price11], [price12], [price13], [price14], [price15], [price16], [price17], [price18], [price19], [price20]) 
VALUES (7, N'111', CAST(64.25 AS Decimal(10, 2)), CAST(99.00 AS Decimal(10, 2)), CAST(76.75 AS Decimal(10, 2)), CAST(76.75 AS Decimal(10, 2)), CAST(31.25 AS Decimal(10, 2)), CAST(101.00 AS Decimal(10, 2)), CAST(40.50 AS Decimal(10, 2)), CAST(47.50 AS Decimal(10, 2)), CAST(42.75 AS Decimal(10, 2)), CAST(85.00 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)), CAST(218.00 AS Decimal(10, 2)), CAST(12.50 AS Decimal(10, 2)), CAST(29.50 AS Decimal(10, 2)), CAST(84.75 AS Decimal(10, 2)), CAST(155.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)), CAST(43.00 AS Decimal(10, 2)), CAST(16.25 AS Decimal(10, 2)), CAST(57.00 AS Decimal(10, 2)));

SET IDENTITY_INSERT [dbo].[pos_priceTbl] OFF;
GO

-- Insert product pictures
SET IDENTITY_INSERT [dbo].[pos_picTbl] ON;
GO

INSERT [dbo].[pos_picTbl] ([id], [pos_id], [pic1], [pic2], [pic3], [pic4], [pic5], [pic6], [pic7], [pic8], [pic9], [pic10], [pic11], [pic12], [pic13], [pic14], [pic15], [pic16], [pic17], [pic18], [pic19], [pic20]) 
VALUES (2, N'123', N'F:\Perfume\VERSACE-EROS1.jpg', N'F:\Perfume\Burberry-Brit-Sheer-For-Women.jpg', N'F:\Perfume\DAVIDOFF_COOLWATER_EDT_M111.jpg', N'F:\Perfume\HUGO-BOSS-THE-SCENT-EDT-FOR-MEN.jpg', N'F:\Perfume\DG_LIGHT_BLUE_EDT_W11.jpg', N'F:\Perfume\CK_ETERNITY_EDP_W11.jpg', N'F:\Perfume\Issey-Miyake-Pour-Homme-.jpg', N'F:\Perfume\CK_ONE_EDT_W11.jpg', N'F:\Perfume\jimmy_choo_edp11.jpg', N'F:\Perfume\versace_bright21.jpg', N'F:\Perfume\DAVIDOFF_COOLWATER_EDT_W11.jpg', N'F:\Perfume\CREED-AVENTUS-EDP-FOR-MEN.jpg', N'F:\Perfume\IN_SHINE_EDT_50ML_SP_W11.jpg', N'F:\Perfume\61228W31.jpg', N'F:\Perfume\chloe-edp-30vp.jpg', N'F:\Perfume\VERSACE-BRIGHT-CRYSTAL-ABSOLU-EDP-FOR-WOMEN1.jpg', N'F:\Perfume\versace_man_fraiche21.jpg', N'F:\Perfume\VERSACE_PH_EDT_M21.jpg', N'F:\Perfume\Bvlgari_Man_Extreme1.jpg', N'F:\Perfume\LANCOME-LA-VIE-EST-BELLE-EDP1.jpg');

INSERT [dbo].[pos_picTbl] ([id], [pos_id], [pic1], [pic2], [pic3], [pic4], [pic5], [pic6], [pic7], [pic8], [pic9], [pic10], [pic11], [pic12], [pic13], [pic14], [pic15], [pic16], [pic17], [pic18], [pic19], [pic20]) 
VALUES (6, N'333', N'F:\Gadget\191063_2024.jpg', N'F:\Gadget\191553_2024.jpg', N'F:\Gadget\177251_2020.jpg', N'F:\Gadget\193098_2024.jpg', N'F:\Gadget\185273_2022.jpg', N'F:\Gadget\194797_2024.jpg', N'F:\Gadget\194403_2024.jpg', N'F:\Gadget\194902_2024.jpg', N'F:\Gadget\185274_2022.jpg', N'F:\Gadget\196369_2025_4.jpg', N'F:\Gadget\189896_2023.jpg', N'F:\Gadget\197110_2025.jpg', N'F:\Gadget\192269_2024.jpg', N'F:\Gadget\196766_2025_10.jpg', N'F:\Gadget\193691_2024.jpg', N'F:\Gadget\194085_2024.jpg', N'F:\Gadget\190863.jpg', N'F:\Gadget\179331_2020_1.jpg', N'F:\Gadget\192852_2024.jpg', N'F:\Gadget\194579_2024_1.jpg');

INSERT [dbo].[pos_picTbl] ([id], [pos_id], [pic1], [pic2], [pic3], [pic4], [pic5], [pic6], [pic7], [pic8], [pic9], [pic10], [pic11], [pic12], [pic13], [pic14], [pic15], [pic16], [pic17], [pic18], [pic19], [pic20]) 
VALUES (7, N'111', N'F:\Grocery\SjDMR4N5eaWdCSTHc8UHdv_watermark_400.jpg', N'F:\Grocery\JeuvRm9eiNXkhU257hnB5R_watermark_400.jpg', N'F:\Grocery\Djv8opCg3Fd7LiBhVmCLGv_watermark_400.jpg', N'F:\Grocery\bDi7972s29T27JPM6QB8Z7_watermark_400.jpg', N'F:\Grocery\bfsLhU7sSdTy498JuGErCt_watermark_400.jpg', N'F:\Grocery\fUH7DgZu9JxwtjLuezwJM6_watermark_400.jpg', N'F:\Grocery\5UGTMSjPSHZFsCWJGjXBPb_watermark_400.jpg', N'F:\Grocery\kvsV4JLB4HZkPCnjMYmo5g_watermark_400.jpg', N'F:\Grocery\WBzAyJmtNompcKWtG56tEW_watermark_400.jpg', N'F:\Grocery\2LVhWdUuNX4hG4VmrnTapt_watermark_400.jpg', N'F:\Grocery\9E8r3MjaiS7NgD5iueWvap_watermark_400.jpg', N'F:\Grocery\aALDC8HhUTbL48cnD86EPg_watermark_400.jpg', N'F:\Grocery\f3PV36ndZfBjawh7yYH4Ef_watermark_400.jpg', N'F:\Grocery\KiWTChjGStjuKwjUiBC4J8_watermark_400.jpg', N'F:\Grocery\2yK2oS2BoJMqJs9gwPyYo2_watermark_400.jpg', N'F:\Grocery\6sbYTjsPwz62vCXcDwXRBE_watermark_400.jpg', N'F:\Grocery\kLnW9Puxkonuvpo2tAhcsp_watermark_400.jpg', N'F:\Grocery\8JF2RSMBnagb47k9WHh964_watermark_400.jpg', N'F:\Grocery\SrvxUk6CS5ui9PvYgSnzf6_watermark_400.jpg', N'F:\Grocery\RzN9K7KVZypgQ5Xo7UiSQf_watermark_400.jpg');

SET IDENTITY_INSERT [dbo].[pos_picTbl] OFF;
GO

-- ================================================================
-- SECTION 5: VERIFY DATA
-- ================================================================

-- Verify the changes
SELECT * FROM employeeTbl;
GO

SELECT * FROM pos_nameTbl;
   SELECT * FROM pos_priceTbl;
   SELECT * FROM pos_picTbl;
   SELECT * FROM employeeTbl;