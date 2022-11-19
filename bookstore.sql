-- --------------------------------------------------------
-- Хост:                         127.0.0.1
-- Версия сервера:               5.6.51 - MySQL Community Server (GPL)
-- Операционная система:         Win64
-- HeidiSQL Версия:              12.0.0.6468
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Дамп структуры базы данных bookstore
CREATE DATABASE IF NOT EXISTS `bookstore` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci */;
USE `bookstore`;

-- Дамп структуры для таблица bookstore.author
CREATE TABLE IF NOT EXISTS `author` (
  `idAuthor` int(11) NOT NULL AUTO_INCREMENT,
  `surname` char(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `name` char(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `patronymic` char(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`idAuthor`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Дамп данных таблицы bookstore.author: ~3 rows (приблизительно)
DELETE FROM `author`;
INSERT INTO `author` (`idAuthor`, `surname`, `name`, `patronymic`) VALUES
	(1, 'Толстой', 'Лев', 'Николаевич'),
	(2, 'Пушкин', 'Александр', 'Сергеевич'),
	(3, 'Достоевский', 'Фёдор', 'Михайлович');

-- Дамп структуры для таблица bookstore.books
CREATE TABLE IF NOT EXISTS `books` (
  `idBooks` int(11) NOT NULL AUTO_INCREMENT,
  `title` char(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `idSections` int(11) NOT NULL,
  `idAuthor` int(11) NOT NULL,
  `idSuppliers` int(11) NOT NULL,
  `idPublisher` int(11) NOT NULL,
  `year` int(11) NOT NULL,
  `quantity` int(11) NOT NULL DEFAULT '0',
  `price` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`idBooks`),
  KEY `FK_books_sections` (`idSections`),
  KEY `FK_books_suppliers` (`idSuppliers`),
  KEY `FK_books_author` (`idAuthor`),
  KEY `FK_books_publishers` (`idPublisher`),
  CONSTRAINT `FK_books_author` FOREIGN KEY (`idAuthor`) REFERENCES `author` (`idAuthor`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_books_publishers` FOREIGN KEY (`idPublisher`) REFERENCES `publishers` (`idPublisher`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_books_sections` FOREIGN KEY (`idSections`) REFERENCES `sections` (`idSections`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_books_suppliers` FOREIGN KEY (`idSuppliers`) REFERENCES `suppliers` (`idSuppliers`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Дамп данных таблицы bookstore.books: ~2 rows (приблизительно)
DELETE FROM `books`;
INSERT INTO `books` (`idBooks`, `title`, `idSections`, `idAuthor`, `idSuppliers`, `idPublisher`, `year`, `quantity`, `price`) VALUES
	(1, 'Капитанская дочка', 3, 1, 3, 2, 1836, 1000, 2500),
	(2, 'Основы программирования для "чайников"', 2, 2, 1, 3, 2008, 150, 4000);

-- Дамп структуры для таблица bookstore.orders
CREATE TABLE IF NOT EXISTS `orders` (
  `idOrders` int(11) NOT NULL AUTO_INCREMENT,
  `idCustomer` int(11) NOT NULL,
  `idBooks` int(11) NOT NULL,
  `quantity` int(11) NOT NULL DEFAULT '0',
  `sum` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`idOrders`),
  KEY `FK_orders_customer` (`idCustomer`),
  KEY `FK_orders_books` (`idBooks`),
  CONSTRAINT `FK_orders_books` FOREIGN KEY (`idBooks`) REFERENCES `books` (`idBooks`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_orders_customer` FOREIGN KEY (`idCustomer`) REFERENCES `сustomer` (`idCustomer`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Дамп данных таблицы bookstore.orders: ~2 rows (приблизительно)
DELETE FROM `orders`;
INSERT INTO `orders` (`idOrders`, `idCustomer`, `idBooks`, `quantity`, `sum`) VALUES
	(1, 3, 2, 2, 8000),
	(3, 2, 1, 1, 2500);

-- Дамп структуры для таблица bookstore.publishers
CREATE TABLE IF NOT EXISTS `publishers` (
  `idPublisher` int(11) NOT NULL AUTO_INCREMENT,
  `title` char(50) COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT '',
  PRIMARY KEY (`idPublisher`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Дамп данных таблицы bookstore.publishers: ~3 rows (приблизительно)
DELETE FROM `publishers`;
INSERT INTO `publishers` (`idPublisher`, `title`) VALUES
	(1, 'ЛитРес'),
	(2, 'АСТ'),
	(3, 'ЭКСМО');

-- Дамп структуры для таблица bookstore.sections
CREATE TABLE IF NOT EXISTS `sections` (
  `idSections` int(11) NOT NULL AUTO_INCREMENT,
  `section` char(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`idSections`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Дамп данных таблицы bookstore.sections: ~4 rows (приблизительно)
DELETE FROM `sections`;
INSERT INTO `sections` (`idSections`, `section`) VALUES
	(1, 'Бизнес'),
	(2, 'Програмирование'),
	(3, 'Литература'),
	(4, 'Домоводство');

-- Дамп структуры для таблица bookstore.suppliers
CREATE TABLE IF NOT EXISTS `suppliers` (
  `idSuppliers` int(11) NOT NULL AUTO_INCREMENT,
  `title` char(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `address` char(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `telephone` char(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`idSuppliers`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Дамп данных таблицы bookstore.suppliers: ~3 rows (приблизительно)
DELETE FROM `suppliers`;
INSERT INTO `suppliers` (`idSuppliers`, `title`, `address`, `telephone`) VALUES
	(1, 'Книжный клуб 36,6', 'Москва. ул. Бакунинская, д. 71, стр. 10', '+7(495)926-45-44'),
	(2, 'Букселлер', 'Москва, Марьиной Рощи 3-й проезд, д. 40 стр. 1, эт', '+7(495)649-89-74'),
	(3, 'Книганика', 'Москва', '7-800-551-41-43');

-- Дамп структуры для таблица bookstore.сustomer
CREATE TABLE IF NOT EXISTS `сustomer` (
  `idCustomer` int(11) NOT NULL AUTO_INCREMENT,
  `fio` char(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `address` char(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `telephone` char(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`idCustomer`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Дамп данных таблицы bookstore.сustomer: ~3 rows (приблизительно)
DELETE FROM `сustomer`;
INSERT INTO `сustomer` (`idCustomer`, `fio`, `address`, `telephone`) VALUES
	(1, 'Иванов Иван Иванович', 'Где-то там 13', '88885553535'),
	(2, 'Семёнов Виталий Альбертович', 'Возят меня 37', '54654566496'),
	(3, 'Савин Витольд Александрович', 'Вот здесь 92', '78665659890');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
