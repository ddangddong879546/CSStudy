#날짜:2022/07/18
#이름:이세연
#내용:교재 2장 테이블에서 데이터 검색

#------------------------------
#4강 Hello World 실행하기
#------------------------------
# 테이블 생성
CREATE TABLE `sample21` (`no`,`name`,`birthday`,`address`)
	`no`	     INT,
	`name`     VARCHAR(10),		
	`birthday` CHAR(10),	
	`address`  VARCHAR(100)
);

# 데이터 저장#
INSERT INTO `sample21` VALUES (1, '박준용','1979-10-18', '대구광역시 수성구');
INSERT INTO `sample21` SET `NO`='2', `name`='김재진',`address`= '대구광역시 동구';
INSERT INTO `sample21` SET `NO`='3', `name`='홍길동',`address`= '서울특별시 마포구';



#p53

#------------------------------
#5강 테이블 구조 참조하기
#------------------------------



#p62

#------------------------------
#6강 검색조건 지정하기
#------------------------------
#p66
#p68
#p70
#p71
#p72
#p73

#------------------------------
#7강 조건 조합하기
#------------------------------
# 테이블 생성/데이터 저장
CREATE TABLE `sample24` (
	`no` INT,
	`a` INT,
	`b` INT,
	`c` INT 
);

INSERT INTO `sample24` ();
INSERT INTO `sample24` ();
INSERT INTO `sample24` ();
INSERT INTO `sample24` ();
INSERT INTO `sample24` ();

#p76
#p77
#p78
#p80
#p82

#------------------------------
#8강 패턴 매칭에 의한 검색
#------------------------------
# 테이블 생성/데이터 저장
CREATE TABLE `sample25` (
	`no` INT,
	`text` VARCHAR(255)
);

INSERT INTO `sample25` SET `text` = '';
INSERT INTO `sample25` SET `text` = '';
INSERT INTO `sample25` SET `text` = '';

#p85
#p86
#p88


