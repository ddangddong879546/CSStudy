#날짜 : 2022/07/21
#이름 : 이세연
#내용 : SQL 연습문제

#실습 6-1
CREATE DATABASE `OrderDB`;
CREATE USER 'master'@'%' IDENTIFIED BY '1234';
GRANT ALL PRIVILEGES ON OrderDB.* TO 'master'@'%';
FLUSH PRIVILEGES;

#실습 6-2
CREATE TABLE `Customer`(
`custId` VARCHAR (10) PRIMARY KEY,
`name` VARCHAR (10) NOT NULL,
`hp` CHAR (13) DEFAULT NULL,   
`addr` VARCHAR (100) DEFAULT NULL,
`rdate` DATE NOT NULL
);

CREATE TABLE `Product`(
`prodNo` INT AUTO_INCREMENT PRIMARY KEY,
`prodName` VARCHAR (10) NOT NULL,
`stock` INT DEFAULT 0,
`price` INT DEFAULT NULL,
`company` VARCHAR (20) NOT NULL
);

CREATE TABLE `Order`(
`orderNo` INT AUTO_INCREMENT PRIMARY KEY,
`orderId` VARCHAR (10) NOT NULL,
`orderProduct` INT NOT NULL,
`orderCount` INT DEFAULT 1,
`orderDate` DATETIME NOT  NULL
);

#실습 6-3
INSERT INTO `Customer` VALUES ('heoj','허준',NULL, NULL,'2022-01-07');
INSERT INTO `Customer` VALUES ('jang','장보고','010-1234-1003','완도군 청산면','2022-01-03');
INSERT INTO `Customer` VALUES ('jeongc','정철','010-1234-1006','경기도 용인시','2022-01-06');
INSERT INTO `Customer` VALUES ('jeongyy','정약용','010-1234-1010','경기도 광주시','2022-01-10');
INSERT INTO `Customer` VALUES ('kang','강감찬','010-1234-1004','서울시 마포구','2022-01-04');
INSERT INTO `Customer` VALUES ('kimcc','김춘추','010-1234-1002','경주시 보문동','2022-01-02');
INSERT INTO `Customer` VALUES ('kimys','김유신','010-1234-1001','김해시 봉황동','2022-01-01');
INSERT INTO `Customer` VALUES ('leesg','이성계',NULL, NULL,'2022-01-05');
INSERT INTO `Customer` VALUES ('leess','이순신','010-1234-1008', '서울시 영등포군','2022-01-08');
INSERT INTO `Customer` VALUES ('songsh','송상현','010-1234-1009','부산시 동래구','2022-01-09');


INSERT INTO `Product` VALUES (1, '새우깡', 5000, 1500, '농심');
INSERT INTO `Product` VALUES (2, '초코파이', 2500, 2500, '오리온');
INSERT INTO `Product` VALUES (3, '포카칩', 3600, 1700, '오리온');
INSERT INTO `Product` VALUES (4, '양파링', 1250, 1800, '농심');
INSERT INTO `Product` VALUES (5, '죠리퐁', 2200, NULL, '크라운');
INSERT INTO `Product` VALUES (6, '마가렛트', 3500, 3500, '롯데');
INSERT INTO `Product` VALUES (7, '뿌셔뿌셔', 1650, 1200, '오뚜기');


INSERT INTO `Order` VALUES (1, 'kimcc', 3, 2, '2022-07-01 13:15:10');
INSERT INTO `Order` VALUES (2, 'kimys', 4, 1, '2022-07-01 14:16:11');
INSERT INTO `Order` VALUES (3, 'leess', 1, 1, '2022-07-01 17:23:18');
INSERT INTO `Order` VALUES (4, 'songsh', 6, 5, '2022-07-02 10:46:36');
INSERT INTO `Order` VALUES (5, 'kimcc', 2, 1, '2022-07-03 09:15:37');
INSERT INTO `Order` VALUES (6, 'kimys', 7, 3, '2022-07-03 12:35:12');
INSERT INTO `Order` VALUES (7, 'jeongyy', 1, 2, '2022-07-03 16:55:36');
INSERT INTO `Order` VALUES (8, 'kang', 2, 4, '2022-07-04 14:23:23');
INSERT INTO `Order` VALUES (9, 'kimcc', 1, 3, '2022-07-04 21:54:34');
INSERT INTO `Order` VALUES (10, 'heoj', 6, 1, '2022-07-05 14:21:03');


#실습 6-4
SELECT * FROM `Customer`;

#실습 6-5
SELECT `custId`, `name`, `hp` FROM `Customer`;

#실습 6-6
SELECT * FROM `Product`;

#실습 6-7
SELECT `company` FROM `Product`;

#실습 6-8
SELECT DISTINCT `company` FROM `product`;

#실습 6-9
SELECT DISTINCT `prodName`,`price` FROM `product`;

#실습 6-10
SELECT `prodName`, `price`+500 AS `조정단가` FROM `product`; 

#실습 6-11
SELECT `prodName`, `stock`, `price` FROM `product` 
WHERE `company` = '오리온';

#실습 6-12
SELECT `orderProduct`, `orderCount`, `orderDate` FROM `order` 
ORDER BY 'kimcc'; 

#실습 6-13
SELECT `orderProduct`, `orderCount`, `orderDate` FROM `order`
WHERE 'kimcc' AND `수량`>= 2;

#실습 6-14
SELECT * FROM `product` WHERE `price`<= 2000 AND 1000 <=`price`;

#실습 6-15
SELECT `custId`, `name`, `hp`, `addr` FROM `customer` WHERE `name` LIKE '김__';

#실습 6-16
SELECT `custId`, `name`, `hp`, `addr` FROM `customer` WHERE `custId` LIKE '____'

#실습 6-17
SELECT * FROM `customer` WHERE `hp`IS NULL;

#실습 6-18
SELECT * FROM `customer` WHERE `addr` IS NOT NULL;

#실습 6-19
SELECT * FROM `customer` order BY `rdate` DESC;

#실습 6-20
SELECT * FROM `order` WHERE `orderCount` >=3 
order BY `orderCount` DESC, `orderCount` = order BY `orderNo` ASC;

#실습 6-21
SELECT `price`,AVG(`price`) AS `평균`FROM `product`;

#실습 6-22
SELECT `stock`,SUM(`stock`) AS `재고량 합계` FROM `product` WHERE `company`='농심';

#실습 6-23
SELECT COUNT(`custid`) AS `고객수` FROM `customer`;

#실습 6-24
SELECT COUNT(DISTINCT `company`) AS `제조업체 수` FROM `product`;

#실습 6-25
SELECT `orderProduct` AS `주문 상품번호`, SUM(`orderCount`) AS `총 주문수량` FROM `order` GROUP BY `orderProduct`;

#실습 6-26
SELECT `company` AS `제조업체`, COUNT(*) AS `제품수`, MAX(`price`) AS `최고가` FROM `product` GROUP BY `company`;

#실습 6-27
SELECT `company` AS `제조업체`, COUNT(*) AS `제품수`, MAX(`price`) AS `최고가` FROM `product` GROUP BY `company` HAVING `제품수` >= 2;

#실습 6-28
SELECT `orderProduct`, `orderId`, SUM(`orderCount`) AS `총 주문수량` FROM `order` GROUP BY `orderProduct`, `orderId`;

#실습 6-29

SELECT a.orderId, b.prodName FROM `order` AS a
JOIN `product` AS b
ON a.orderProduct = b.prodNo
WHERE `orderid` = 'kimcc';

#실습 6-30

SELECT `orderid`, `name`, `prodName`, `orderDate` FROM `order` AS a
JOIN `customer` AS b
ON a.orderId = b.custId
JOIN `product` AS c
ON a.orderProduct = c.prodNo
WHERE SUBSTR(`orderDate`, 1, 10) = '2022-07-03';



