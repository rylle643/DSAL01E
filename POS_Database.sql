CREATE DATABASE POS_Database;
GO

USE POS_Database;
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
    useraccount_id INT IDENTITY(1,1),
    user_id INT PRIMARY KEY,
    account_type VARCHAR(100),
    username VARCHAR(50),
    password VARCHAR(100),
    confirm_password VARCHAR(100),
    user_status VARCHAR(50),
    emp_id VARCHAR(50),
    pos_terminal_no VARCHAR(50)
);
GO

-- Table 3: pos_nameTbl
CREATE TABLE pos_nameTbl (
    name_id INT IDENTITY(1,1),
    pos_id VARCHAR(20) PRIMARY KEY,
    name1 VARCHAR(50),
    name2 VARCHAR(50),
    name3 VARCHAR(50),
    name4 VARCHAR(50),
    name5 VARCHAR(50),
    name6 VARCHAR(50),
    name7 VARCHAR(50),
    name8 VARCHAR(50),
    name9 VARCHAR(50),
    name10 VARCHAR(50),
    name11 VARCHAR(50),
    name12 VARCHAR(50),
    name13 VARCHAR(50),
    name14 VARCHAR(50),
    name15 VARCHAR(50),
    name16 VARCHAR(50),
    name17 VARCHAR(50),
    name18 VARCHAR(50),
    name19 VARCHAR(50),
    name20 VARCHAR(50),
    employee_id VARCHAR(50)
);
GO

-- Table 4: pos_priceTbl
CREATE TABLE pos_priceTbl (
    price_id INT IDENTITY(1,1) PRIMARY KEY,
    price1 VARCHAR(50),
    price2 VARCHAR(50),
    price3 VARCHAR(50),
    price4 VARCHAR(50),
    price5 VARCHAR(50),
    price6 VARCHAR(50),
    price7 VARCHAR(50),
    price8 VARCHAR(50),
    price9 VARCHAR(50),
    price10 VARCHAR(50),
    price11 VARCHAR(50),
    price12 VARCHAR(50),
    price13 VARCHAR(50),
    price14 VARCHAR(50),
    price15 VARCHAR(50),
    price16 VARCHAR(50),
    price17 VARCHAR(50),
    price18 VARCHAR(50),
    price19 VARCHAR(50),
    price20 VARCHAR(50),
    pos_id INT
);
GO

-- Table 5: pos_picTbl
CREATE TABLE pos_picTbl (
    pic_id INT IDENTITY(1,1) PRIMARY KEY,
    pic1 TEXT,
    pic2 TEXT,
    pic3 TEXT,
    pic4 TEXT,
    pic5 TEXT,
    pic6 TEXT,
    pic7 TEXT,
    pic8 TEXT,
    pic9 TEXT,
    pic10 TEXT,
    pic11 TEXT,
    pic12 TEXT,
    pic13 TEXT,
    pic14 TEXT,
    pic15 TEXT,
    pic16 TEXT,
    pic17 TEXT,
    pic18 TEXT,
    pic19 TEXT,
    pic20 TEXT,
    pos_id INT
);
GO

-- Table 6: salesTbl
CREATE TABLE salesTbl (
    transaction_id INT IDENTITY(1,1) PRIMARY KEY,
    product_name VARCHAR(100),
    product_price VARCHAR(50),
    product_quantity_per_transaction VARCHAR(50),
    discount_option VARCHAR(50),
    discount_amount_per_transaction VARCHAR(50),
    discounted_amount_per_transaction VARCHAR(50),
    summary_total_quantity VARCHAR(50),
    summary_total_disc_given VARCHAR(50),
    summary_total_discounted_amount VARCHAR(50),
    terminal_no VARCHAR(50),
    time_date VARCHAR(50),
    emp_id VARCHAR(50)
);
GO

-- Table 7: payrolTbl
CREATE TABLE payrolTbl (
    payrol_id INT IDENTITY(1,1) PRIMARY KEY,
    basic_rate_hr VARCHAR(50),
    basic_no_of_hrs_cutoff VARCHAR(50),
    basic_income_per_cutoff VARCHAR(50),
    honorarium_rate_hr VARCHAR(50),
    honorarium_no_of_hrs_cutoff VARCHAR(50),
    honorarium_income_per_cutoff VARCHAR(50),
    other_rate_hr VARCHAR(50),
    other_no_of_hrs_cutoff VARCHAR(50),
    other_income_per_cutoff VARCHAR(50),
    sss_contrib VARCHAR(50),
    philhealth_contrib VARCHAR(50),
    pagibig_contrib VARCHAR(50),
    tax_contrib VARCHAR(50),
    sss_loan VARCHAR(50),
    pagibig_loan VARCHAR(50),
    fac_savings_deposit VARCHAR(50),
    fac_savings_loan VARCHAR(50),
    salary_loan VARCHAR(50),
    other_loans VARCHAR(50),
    total_deductions VARCHAR(50),
    gross_income VARCHAR(50),
    net_income VARCHAR(50),
    emp_id VARCHAR(50),
    pay_date VARCHAR(50)
);
GO

-- Table 8: pos_empRegTbl
CREATE TABLE pos_empRegTbl (
    empReg_id INT IDENTITY(1,1),
    emp_id VARCHAR(50) PRIMARY KEY,
    emp_fname VARCHAR(100),
    emp_mname VARCHAR(50),
    emp_surname VARCHAR(100),
    emp_age INT,
    emp_gender VARCHAR(30),
    emp_sss_no INT,
    emp_tin_no INT,
    emp_philhealth_no INT,
    emp_pagibig_no INT,
    emp_status VARCHAR(50),
    emp_height VARCHAR(50),
    emp_weight VARCHAR(50),
    add_yrs_stay INT,
    add_house_no INT,
    add_sub_name TEXT,
    add_phase_no INT,
    add_street VARCHAR(100),
    add_barangay VARCHAR(100),
    add_municipality VARCHAR(100),
    add_city VARCHAR(100),
    add_state_province VARCHAR(100),
    add_country VARCHAR(100),
    add_zipcode INT,
    elem_name TEXT,
    elem_address TEXT,
    elem_yr_grad VARCHAR(50),
    elem_award VARCHAR(50),
    junior_high_name TEXT,
    junior_high_address TEXT,
    junior_high_yr_grad VARCHAR(50),
    junior_high_award VARCHAR(50),
    senior_high_name TEXT,
    senior_high_address TEXT,
    senior_high_yr_grad VARCHAR(50),
    senior_high_award VARCHAR(50),
    track VARCHAR(50),
    college_school_name TEXT,
    college_address TEXT,
    college_yr_grad VARCHAR(50),
    college_award VARCHAR(50),
    college_course VARCHAR(100),
    others TEXT,
    position VARCHAR(50),
    emp_work_status VARCHAR(50),
    emp_date_hired VARCHAR(100),
    emp_department VARCHAR(50),
    emp_no_of_dependents INT,
    picpath TEXT
);
GO

-- ================================================================
-- SECTION 2: ALTER TABLES
-- ================================================================

-- Add account_type column to employeeTbl
ALTER TABLE employeeTbl
ADD account_type VARCHAR(50);
GO

-- ================================================================
-- SECTION 3: ADD FOREIGN KEY CONSTRAINTS
-- ================================================================

-- Add foreign key constraints
ALTER TABLE pos_empRegTbl
ADD CONSTRAINT FK_posEmpReg_employee 
FOREIGN KEY (emp_id) REFERENCES employeeTbl(emp_id);
GO

ALTER TABLE useraccountTbl
ADD CONSTRAINT FK_userAccount_employee 
FOREIGN KEY (emp_id) REFERENCES employeeTbl(emp_id);
GO

ALTER TABLE payrolTbl
ADD CONSTRAINT FK_payrol_employee 
FOREIGN KEY (emp_id) REFERENCES employeeTbl(emp_id);
GO

ALTER TABLE salesTbl
ADD CONSTRAINT FK_sales_employee 
FOREIGN KEY (emp_id) REFERENCES employeeTbl(emp_id);
GO

-- ================================================================
-- SECTION 4: CREATE INDEXES
-- ================================================================

-- Create Indexes for better performance
CREATE INDEX IX_pos_nameTbl_pos_id ON pos_nameTbl(pos_id);
CREATE INDEX IX_pos_priceTbl_pos_id ON pos_priceTbl(pos_id);
CREATE INDEX IX_pos_picTbl_pos_id ON pos_picTbl(pos_id);
CREATE INDEX IX_salesTbl_emp_id ON salesTbl(emp_id);
CREATE INDEX IX_payrolTbl_emp_id ON payrolTbl(emp_id);
GO

-- ================================================================
-- SECTION 5: INSERT SAMPLE DATA
-- ================================================================

-- Insert sample employees into employeeTbl
INSERT INTO employeeTbl (emp_id, emp_fname, emp_surname, terminal_no, account_type) 
VALUES ('123', 'John', 'Doe', 'Terminal 1', 'Administrator'), 
       ('456', 'Jo', 'Dela Cruz', 'Terminal 2', 'Cashier'), 
       ('789', 'Jack', 'Delima', 'Terminal 3', 'Cashier'), 
       ('101', 'Jane', 'Deguzman', 'Terminal 4', 'Cashier'), 
       ('112', 'James', 'Deontology', 'Terminal 5', 'Cashier');
GO

-- Insert sample user accounts into useraccountTbl
INSERT INTO useraccountTbl (user_id, account_type, username, password, confirm_password, user_status, emp_id, pos_terminal_no)
VALUES (1, 'Administrator', 'admin', 'admin123', 'admin123', 'Active', '123', 'Terminal 1'),
       (2, 'Cashier', 'cashier1', 'pass123', 'pass123', 'Active', '456', 'Terminal 2'),
       (3, 'Cashier', 'cashier2', 'pass123', 'pass123', 'Active', '789', 'Terminal 3');
GO

-- Insert product names into pos_nameTbl
SET IDENTITY_INSERT [dbo].[pos_nameTbl] ON;
GO

INSERT INTO pos_nameTbl (name_id, pos_id, name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12, name13, name14, name15, name16, name17, name18, name19, name20, employee_id) 
VALUES (2, '123', 'VERSACE EROS EDT FOR MEN', 'BURBERRY BRIT SHEER EDT FOR WOMEN', 'DAVIDOFF COOL WATER EDT FOR MEN', 'HUGO BOSS THE SCENT EDT FOR MEN', 'DOLCE & GABBANA D&G LIGHT BLUE EDT FOR WOMEN', 'CALVIN KLEIN CK ETERNITY EDP FOR WOMEN', 'ISSEY MIYAKE L''EAU D''ISSEY POUR HOMME EDT FOR MEN', 'CALVIN KLEIN CK ONE EDT UNISEX', 'JIMMY CHOO EDP FOR WOMEN', 'VERSACE BRIGHT CRYSTAL EDT FOR WOMEN', 'DAVIDOFF COOL WATER EDT FOR WOMEN', 'CREED AVENTUS EDP FOR MEN', 'SALVATORE FERRAGAMO INCANTO SHINE EDT FOR WOMEN', 'VIKTOR & ROLF FLOWERBOMB EDP FOR WOMEN', 'CHLOE EDP FOR WOMEN', 'VERSACE BRIGHT CRYSTAL ABSOLU EDP FOR WOMEN', 'VERSACE MAN EAU FRAICHE EDT FOR MEN', 'VERSACE POUR HOMME EDT FOR MEN', 'BVLGARI MAN EXTREME EDT FOR MEN', 'LANCOME LA VIE EST BELLE EDP FOR WOMEN', '123');

INSERT INTO pos_nameTbl (name_id, pos_id, name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12, name13, name14, name15, name16, name17, name18, name19, name20, employee_id) 
VALUES (6, '333', 'Cricut EasyPress Mini, Zen Blue', 'Sony PlayStation 5 Slim', 'Apple iPhone 13', 'Acer Nitro V ANV15-41-R2M0 Black', 'Cricut EasyPress 3', 'Anker Zolo Charger Pink', 'ZAGG Crystal Palace iPhone 16 Pro Clear Case', 'UGREEN Smart Bluetooth Finder CM520/60387', 'Cricut Mug Press', 'Huawei Band 10 Black', 'HP Smart Tank 580 1F3Y2A', 'TECNO Camon 40 Pro 5G (12GB + 256GB) Glacier White', 'Insta360 X4 Standard Bundle', 'Apple iPad Air 13-inch (7th Gen) Wi-Fi', 'UGREEN PB311 10000mAh 20W Power Bank', 'GoPro HERO', 'Huawei MateBook D16 MCLF-W5651 Silver', 'Nintendo Switch OLED Neon Blue/Neon Red', 'Apple Pencil Pro', 'Apple AirPods 4 with Active Noise Cancellation', '456');

INSERT INTO pos_nameTbl (name_id, pos_id, name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12, name13, name14, name15, name16, name17, name18, name19, name20, employee_id) 
VALUES (7, '111', 'M.Y. San Skyflakes Crackers', 'Hermano Refined Sugar', 'Knorr Beef Broth Cubes', 'Knorr Chicken Broth Cubes', 'Knorr Sinigang Original', 'Cowhead Pure Milk', 'VCut Potato Chips Spicy Barbeque Flavor', 'Century Tuna Flakes in Vegetable Oil', 'Datu Puti Vinegar', 'Gardenia Classic White Bread', 'Yakult Probiotic Drink', 'Spam Lite Luncheon Meat', 'Bread Pan Cheese & Onion Toasted Bread', 'Sinigang sa Sampalok na may Gabi', 'Hermano Brown Sugar', 'Argentina Beef Tapa', 'Jolly Finger Cream Sandwich Cookies', 'Fibisco Choco Mallows Biscuits', 'Absolute Pure Distilled Drinking Water', 'Marby Spanish Bread', '789');

SET IDENTITY_INSERT [dbo].[pos_nameTbl] OFF;
GO

-- Insert product prices into pos_priceTbl
SET IDENTITY_INSERT [dbo].[pos_priceTbl] ON;
GO

INSERT INTO pos_priceTbl (price_id, price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12, price13, price14, price15, price16, price17, price18, price19, price20, pos_id)
VALUES (2, '5999.00', '3399.00', '3599.00', '5999.00', '4999.00', '3399.00', '4699.00', '2999.00', '5399.00', '5499.00', '2999.00', '23999.00', '3999.00', '9999.00', '6699.00', '5999.00', '4999.00', '4999.00', '8999.00', '7999.00', 123);

INSERT INTO pos_priceTbl (price_id, price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12, price13, price14, price15, price16, price17, price18, price19, price20, pos_id)
VALUES (6, '2699.00', '30790.00', '25990.00', '43499.00', '7999.00', '575.00', '1090.00', '949.00', '9999.00', '2099.00', '8995.00', '14999.00', '25890.00', '75990.00', '999.00', '9990.00', '30999.00', '16990.00', '9290.00', '10490.00', 333);

INSERT INTO pos_priceTbl (price_id, price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12, price13, price14, price15, price16, price17, price18, price19, price20, pos_id)
VALUES (7, '64.25', '99.00', '76.75', '76.75', '31.25', '101.00', '40.50', '47.50', '42.75', '85.00', '50.00', '218.00', '12.50', '29.50', '84.75', '155.00', '70.00', '43.00', '16.25', '57.00', 111);

SET IDENTITY_INSERT [dbo].[pos_priceTbl] OFF;
GO

-- Insert product pictures into pos_picTbl
SET IDENTITY_INSERT [dbo].[pos_picTbl] ON;
GO

INSERT INTO pos_picTbl (pic_id, pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10, pic11, pic12, pic13, pic14, pic15, pic16, pic17, pic18, pic19, pic20, pos_id)
VALUES (2, 'F:\Perfume\VERSACE-EROS1.jpg', 'F:\Perfume\Burberry-Brit-Sheer-For-Women.jpg', 'F:\Perfume\DAVIDOFF_COOLWATER_EDT_M111.jpg', 'F:\Perfume\HUGO-BOSS-THE-SCENT-EDT-FOR-MEN.jpg', 'F:\Perfume\DG_LIGHT_BLUE_EDT_W11.jpg', 'F:\Perfume\CK_ETERNITY_EDP_W11.jpg', 'F:\Perfume\Issey-Miyake-Pour-Homme-.jpg', 'F:\Perfume\CK_ONE_EDT_W11.jpg', 'F:\Perfume\jimmy_choo_edp11.jpg', 'F:\Perfume\versace_bright21.jpg', 'F:\Perfume\DAVIDOFF_COOLWATER_EDT_W11.jpg', 'F:\Perfume\CREED-AVENTUS-EDP-FOR-MEN.jpg', 'F:\Perfume\IN_SHINE_EDT_50ML_SP_W11.jpg', 'F:\Perfume\61228W31.jpg', 'F:\Perfume\chloe-edp-30vp.jpg', 'F:\Perfume\VERSACE-BRIGHT-CRYSTAL-ABSOLU-EDP-FOR-WOMEN1.jpg', 'F:\Perfume\versace_man_fraiche21.jpg', 'F:\Perfume\VERSACE_PH_EDT_M21.jpg', 'F:\Perfume\Bvlgari_Man_Extreme1.jpg', 'F:\Perfume\LANCOME-LA-VIE-EST-BELLE-EDP1.jpg', 123);

INSERT INTO pos_picTbl (pic_id, pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10, pic11, pic12, pic13, pic14, pic15, pic16, pic17, pic18, pic19, pic20, pos_id)
VALUES (6, 'F:\Gadget\191063_2024.jpg', 'F:\Gadget\191553_2024.jpg', 'F:\Gadget\177251_2020.jpg', 'F:\Gadget\193098_2024.jpg', 'F:\Gadget\185273_2022.jpg', 'F:\Gadget\194797_2024.jpg', 'F:\Gadget\194403_2024.jpg', 'F:\Gadget\194902_2024.jpg', 'F:\Gadget\185274_2022.jpg', 'F:\Gadget\196369_2025_4.jpg', 'F:\Gadget\189896_2023.jpg', 'F:\Gadget\197110_2025.jpg', 'F:\Gadget\192269_2024.jpg', 'F:\Gadget\196766_2025_10.jpg', 'F:\Gadget\193691_2024.jpg', 'F:\Gadget\194085_2024.jpg', 'F:\Gadget\190863.jpg', 'F:\Gadget\179331_2020_1.jpg', 'F:\Gadget\192852_2024.jpg', 'F:\Gadget\194579_2024_1.jpg', 333);

INSERT INTO pos_picTbl (pic_id, pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10, pic11, pic12, pic13, pic14, pic15, pic16, pic17, pic18, pic19, pic20, pos_id)
VALUES (7, 'F:\Grocery\SjDMR4N5eaWdCSTHc8UHdv_watermark_400.jpg', 'F:\Grocery\JeuvRm9eiNXkhU257hnB5R_watermark_400.jpg', 'F:\Grocery\Djv8opCg3Fd7LiBhVmCLGv_watermark_400.jpg', 'F:\Grocery\bDi7972s29T27JPM6QB8Z7_watermark_400.jpg', 'F:\Grocery\bfsLhU7sSdTy498JuGErCt_watermark_400.jpg', 'F:\Grocery\fUH7DgZu9JxwtjLuezwJM6_watermark_400.jpg', 'F:\Grocery\5UGTMSjPSHZFsCWJGjXBPb_watermark_400.jpg', 'F:\Grocery\kvsV4JLB4HZkPCnjMYmo5g_watermark_400.jpg', 'F:\Grocery\WBzAyJmtNompcKWtG56tEW_watermark_400.jpg', 'F:\Grocery\2LVhWdUuNX4hG4VmrnTapt_watermark_400.jpg', 'F:\Grocery\9E8r3MjaiS7NgD5iueWvap_watermark_400.jpg', 'F:\Grocery\aALDC8HhUTbL48cnD86EPg_watermark_400.jpg', 'F:\Grocery\f3PV36ndZfBjawh7yYH4Ef_watermark_400.jpg', 'F:\Grocery\KiWTChjGStjuKwjUiBC4J8_watermark_400.jpg', 'F:\Grocery\2yK2oS2BoJMqJs9gwPyYo2_watermark_400.jpg', 'F:\Grocery\6sbYTjsPwz62vCXcDwXRBE_watermark_400.jpg', 'F:\Grocery\kLnW9Puxkonuvpo2tAhcsp_watermark_400.jpg', 'F:\Grocery\8JF2RSMBnagb47k9WHh964_watermark_400.jpg', 'F:\Grocery\SrvxUk6CS5ui9PvYgSnzf6_watermark_400.jpg', 'F:\Grocery\RzN9K7KVZypgQ5Xo7UiSQf_watermark_400.jpg', 111);

SET IDENTITY_INSERT [dbo].[pos_picTbl] OFF;
GO

-- Insert sample employee registration data
INSERT INTO pos_empRegTbl (emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_sss_no, emp_tin_no, emp_philhealth_no, emp_pagibig_no, emp_status, emp_height, emp_weight, add_yrs_stay, add_house_no, add_sub_name, add_phase_no, add_street, add_barangay, add_municipality, add_city, add_state_province, add_country, add_zipcode, position, emp_work_status, emp_date_hired, emp_department, emp_no_of_dependents, picpath)
VALUES ('123', 'John', 'A', 'Doe', 30, 'Male', 1234567, 9876543, 123456, 123456, 'Single', '5.8', '160', 5, 123, 'Sample Subdivision', 1, 'Main Street', 'Barangay 1', 'Sample Municipality', 'Sample City', 'Sample Province', 'Philippines', 1234, 'Manager', 'Active', '2023-01-15', 'Management', 2, 'F:\Employees\480250259_1012033260949681_2998066661353150187_n.jpg');

INSERT INTO pos_empRegTbl (emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_sss_no, emp_tin_no, emp_philhealth_no, emp_pagibig_no, emp_status, emp_height, emp_weight, add_yrs_stay, add_house_no, add_sub_name, add_phase_no, add_street, add_barangay, add_municipality, add_city, add_state_province, add_country, add_zipcode, position, emp_work_status, emp_date_hired, emp_department, emp_no_of_dependents, picpath)
VALUES ('456', 'Jo', 'B', 'Dela Cruz', 28, 'Female', 2345678, 8765432, 234567, 234567, 'Married', '5.4', '120', 3, 456, 'Another Subdivision', 2, 'Second Street', 'Barangay 2', 'Another Municipality', 'Another City', 'Another Province', 'Philippines', 5678, 'Cashier', 'Active', '2023-03-20', 'Sales', 3, 'F:\Employees\F5XJ9f0akAAfxJL.jpg');

INSERT INTO pos_empRegTbl (emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_sss_no, emp_tin_no, emp_philhealth_no, emp_pagibig_no, emp_status, emp_height, emp_weight, add_yrs_stay, add_house_no, add_sub_name, add_phase_no, add_street, add_barangay, add_municipality, add_city, add_state_province, add_country, add_zipcode, position, emp_work_status, emp_date_hired, emp_department, emp_no_of_dependents, picpath)
VALUES ('789', 'Jack', 'C', 'Delima', 35, 'Male', 3456789, 7654321, 345678, 345678, 'Married', '5.10', '180', 7, 789, 'Third Subdivision', 3, 'Third Street', 'Barangay 3', 'Third Municipality', 'Third City', 'Third Province', 'Philippines', 9012, 'Cashier', 'Active', '2022-11-10', 'Sales', 4, 'F:\Employees\480399998_1012033160949691_1340788830259894416_n.jpg');
GO

ALTER TABLE payrolTbl
DROP CONSTRAINT FK_payrol_employee;

ALTER TABLE payrolTbl
ADD CONSTRAINT FK_payrol_posEmpReg 
FOREIGN KEY (emp_id) REFERENCES pos_empRegTbl(emp_id);

SELECT 
    fk.name AS ForeignKeyName,
    tp.name AS ParentTable,
    cp.name AS ParentColumn,
    tr.name AS ReferencedTable,
    cr.name AS ReferencedColumn
FROM 
    sys.foreign_keys AS fk
INNER JOIN 
    sys.tables AS tp ON fk.parent_object_id = tp.object_id
INNER JOIN 
    sys.tables AS tr ON fk.referenced_object_id = tr.object_id
INNER JOIN 
    sys.foreign_key_columns AS fkc ON fk.object_id = fkc.constraint_object_id
INNER JOIN 
    sys.columns AS cp ON fkc.parent_column_id = cp.column_id AND fkc.parent_object_id = cp.object_id
INNER JOIN 
    sys.columns AS cr ON fkc.referenced_column_id = cr.column_id AND fkc.referenced_object_id = cr.object_id
WHERE 
    tp.name = 'payrolTbl' OR tp.name = 'pos_empRegTbl';

    -- Drop all foreign key constraints one by one
ALTER TABLE payrolTbl
DROP CONSTRAINT FK_payrol_employee;
GO

ALTER TABLE pos_empRegTbl
DROP CONSTRAINT FK_posEmpReg_employee;
GO

ALTER TABLE useraccountTbl
DROP CONSTRAINT FK_userAccount_employee;
GO

ALTER TABLE salesTbl
DROP CONSTRAINT FK_sales_employee;
GO

SELECT 
    fk.name AS ConstraintName,
    OBJECT_NAME(fk.parent_object_id) AS TableName,
    COL_NAME(fkc.parent_object_id, fkc.parent_column_id) AS ColumnName,
    OBJECT_NAME(fk.referenced_object_id) AS ReferencedTable,
    COL_NAME(fkc.referenced_object_id, fkc.referenced_column_id) AS ReferencedColumn
FROM 
    sys.foreign_keys AS fk
INNER JOIN 
    sys.foreign_key_columns AS fkc ON fk.object_id = fkc.constraint_object_id
WHERE 
    OBJECT_NAME(fk.parent_object_id) IN ('payrolTbl', 'pos_empRegTbl', 'useraccountTbl', 'salesTbl');