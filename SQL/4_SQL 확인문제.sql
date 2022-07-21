#날짜 : 2022/07/19
#이름 : 이세연
#내용 : 확인문제
saledbsaledb
CREATE TABLE `tbl_member`(
`memberID` VARCHAR (10) PRIMARY KEY,
`memberName` VARCHAR (10) NOT NULL,
`memberHp` CHAR (13),
`memberAge` TINYINT,
`memberAddr` VARCHAR (20)
);

INSERT INTO `tbl_member` VALUES ('p101','김유신','010-1234-1001',25,'신라')
INSERT INTO `tbl_member` VALUES ('p102','김춘추','010-1234-1002',23,'신라')
INSERT INTO `tbl_member` SET `memberID`='p103', `memberName`='장보고',`memberAge`=31,`memberAddr`='통일신라';
INSERT INTO `tbl_member` SET `memberID`='p104', `memberName`='강감찬',`memberAddr`='고려';
INSERT INTO `tbl_member` SET `memberID`='p105', `memberName`='이순신',`memberHp`='010-1234-1005',`memberAge`=50;



CREATE TABLE `tbl_product`(
`productCode` INT AUTO_INCREMENT PRIMARY KEY,
`productName` VARCHAR (10) NOT NULL,
`price`       INT NOT NULL,
`amount`      INT NOT NULL DEFAULT 0,
`company`     VARCHAR (10),
`makeDate`    DATE
);

INSERT INTO `tbl_product` VALUES (1, '냉장고', 800, 10, 'LG', '2022-01-06')
INSERT INTO `tbl_product` VALUES (2, '노트북', 1200, 20, '삼성', '2022-01-06')
INSERT INTO `tbl_product` VALUES (3, 'TV', 1400, 6, 'LG', '2022-01-06')
INSERT INTO `tbl_product` VALUES (4, '세탁기', 1000, 8, 'LG', '2022-01-06')
INSERT INTO `tbl_product` VALUES (6, '휴대폰', 900, 102, '삼성', '2022-01-06')
INSERT INTO `tbl_product` SET `productCode`=5, `productName`='컴퓨터',`price`=1100;


SELECT `memberName` FROM `tbl_member`;
SELECT `memberName`,`memberHp` FROM `tbl_member`;
SELECT * FROM `tbl_member` WHERE `memberID`='p102';
SELECT * FROM `tbl_member` WHERE `memberID`='p104' OR `memberID`='p105';
UPDATE `tbl_member` SET `memberAge`= 42 WHERE `memberID`='p104';
UPDATE `tbl_member` SET `memberAddr` = '조선' WHERE `memberID`='p105';
DELETE FROM `tbl_member` WHERE `memberID`='p103';
SELECT * FROM `tbl_member`;

SELECT `productName` FROM `tbl_product`;
SELECT * FROM `tbl_product`WHERE `company`='LG';
UPDATE `tbl_product` SET
                        `company`='삼성',
                        `makeDate`='2021-01-01'
                        WHERE
                        `productCode`=5;







