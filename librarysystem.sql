-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 22, 2020 at 07:27 AM
-- Server version: 10.4.10-MariaDB
-- PHP Version: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `librarysystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_accounts`
--

CREATE TABLE `tbl_accounts` (
  `ID` int(11) NOT NULL,
  `FirstName` varchar(50) NOT NULL,
  `MiddleName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_accounts`
--

INSERT INTO `tbl_accounts` (`ID`, `FirstName`, `MiddleName`, `LastName`, `Username`, `Password`) VALUES
(1, 'James', 'Flores', 'Perez', 'admin', 'mdphv'),
(2, 'Mark Angelo', 'D', 'De Guzman', 'admin2', 'pdun'),
(3, 'Tom', 'Concepcion', 'Ocampo', 'admin3', 'wrp');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_books`
--

CREATE TABLE `tbl_books` (
  `BookID` int(11) NOT NULL,
  `BookAuthor` varchar(50) NOT NULL,
  `BookTitle` varchar(100) NOT NULL,
  `PageNumber` varchar(50) NOT NULL,
  `Publisher` varchar(50) NOT NULL,
  `Location` varchar(50) NOT NULL,
  `Subject` varchar(50) NOT NULL,
  `InStock` int(10) NOT NULL,
  `AvailableQuantity` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_books`
--

INSERT INTO `tbl_books` (`BookID`, `BookAuthor`, `BookTitle`, `PageNumber`, `Publisher`, `Location`, `Subject`, `InStock`, `AvailableQuantity`) VALUES
(1, 'J.K. Rowling', 'Harry Potter and the Philospher Stone', '223', 'Bloombury Publishing', 'United Kingdom', 'Novel Fantasy', 10, 10),
(2, 'J.K. Rowling', 'Harry Potter and the Chamber of Secrets', '251', 'Bloombury Publishing', 'United Kingdom', 'Novel Fantasy', 10, 9),
(3, 'J.K. Rowling', 'Harry Potter and the Prisoner of Azkaban', '317', 'Bloombury Publishing', 'United Kingdom', 'Novel Fantasy', 10, 10),
(4, 'J.K. Rowling', 'Harry Potter and the Goblet of Fire', '636', 'Bloombury Publishing', 'United Kingdom', 'Novel Fantasy', 10, 10),
(5, 'J.K. Rowling', 'Harry Potter and the Order of the Phoenix', '766', 'Bloombury Publishing', 'United Kingdom', 'Novel Fantasy', 10, 10),
(6, 'J.K. Rowling', 'Harry Potter and the Half-Blood Prince', '607', 'Bloombury Publishing', 'United Kingdom', 'Novel Fantasy', 10, 9),
(7, 'J.K. Rowling', 'Harry Potter and the Deathly Hallows', '607', 'Bloombury Publishing', 'United Kingdom', 'Novel Fantasy', 10, 10);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_borrowedbooks`
--

CREATE TABLE `tbl_borrowedbooks` (
  `TransactionID` int(10) NOT NULL,
  `StudentName` varchar(50) NOT NULL,
  `Course` varchar(10) NOT NULL,
  `BookName` varchar(50) NOT NULL,
  `BorrowDate` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_borrowedbooks`
--

INSERT INTO `tbl_borrowedbooks` (`TransactionID`, `StudentName`, `Course`, `BookName`, `BorrowDate`) VALUES
(2, 'Elmiera', 'BSCS', 'Harry Potter and the Half-Blood Prince', 'Sunday, 22 March 2020'),
(3, 'Elmiera', 'BSCS', 'Harry Potter and the Chamber of Secrets', 'Sunday, 22 March 2020');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_history`
--

CREATE TABLE `tbl_history` (
  `TransactionID` int(11) NOT NULL,
  `StudentName` varchar(50) NOT NULL,
  `Course` varchar(50) NOT NULL,
  `BookName` varchar(50) NOT NULL,
  `BorrowDate` varchar(50) NOT NULL,
  `ReturnDate` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_history`
--

INSERT INTO `tbl_history` (`TransactionID`, `StudentName`, `Course`, `BookName`, `BorrowDate`, `ReturnDate`) VALUES
(1, 'Elmiera', 'BSCS', 'Harry Potter and the Deathly Hallows', 'Sunday, 22 March 2020', 'Sunday, 22 March 2020');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_students`
--

CREATE TABLE `tbl_students` (
  `StudentID` int(10) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `FirstName` varchar(50) NOT NULL,
  `MiddleInitial` varchar(5) NOT NULL,
  `Course` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_students`
--

INSERT INTO `tbl_students` (`StudentID`, `LastName`, `FirstName`, `MiddleInitial`, `Course`) VALUES
(1, 'Abasola', 'Elmiera', 'E.', 'BSCS'),
(2, 'Agliam', 'Aeron', 'M.', 'BSCS'),
(3, 'Angeles', 'Justine Paul', 'R.', 'BSCS'),
(4, 'Arag', 'Anna Marie', 'A.', 'BSCS'),
(5, 'Bañez', 'Aubrey', 'A.', 'BSCS'),
(6, 'Bauzon', 'Clarence', 'C.', 'BSCS'),
(7, 'Borja', 'Joana Rose', 'N.', 'BSCS'),
(8, 'Buenavidez', 'Alyssa', '', 'BSCS'),
(9, 'Cababat', 'Romel', 'B.', 'BSCS'),
(10, 'Concepcion', 'Christopher', 'P.', 'BSCS'),
(11, 'Custodio', 'Alvin Rhoy', 'F.', 'BSCS'),
(12, 'De Castro', 'James Aldrin', 'R.', 'BSCS'),
(13, 'De Guzman', 'Mark Angelo', 'D.', 'BSCS'),
(14, 'De Jesus', 'Juan Carlo', 'L.', 'BSCS'),
(15, 'Deinla', 'Aubrey', 'G,', 'BSCS'),
(16, 'Dela Torre', 'Erwin', 'DL.', 'BSCS'),
(17, 'Desuacido', 'Diana Mae', 'D.', 'BSCS'),
(18, 'Dollete', 'Adrian', 'T.', 'BSCS'),
(19, 'Fajardo', 'Jouie', 'C.', 'BSCS'),
(20, 'Fariñas', 'Job', 'T.', 'BSCS'),
(21, 'Filoteo', 'Christian', 'E.', 'BSCS'),
(22, 'Galvez', 'Edson', 'R.', 'BSCS'),
(23, 'Japson', 'Rolly Boy', 'C.', 'BSCS'),
(24, 'Justiniano', 'John Paul', 'A.', 'BSCS'),
(25, 'Manalaysay', 'Jeremy', 'DC.', 'BSCS'),
(26, 'Naig', 'Eugene', 'R.', 'BSCS'),
(27, 'Ocampo', 'Tom', 'C.', 'BSCS'),
(28, 'Ocenar', 'Glenn', 'F.', 'BSCS'),
(29, 'Palad', 'Reiven Jazzmine', 'S.', 'BSCS'),
(30, 'Panganiban', 'Elton John', 'L.', 'BSCS'),
(31, 'Perez', 'James', 'F.', 'BSCS'),
(32, 'Perjes', 'Joseph Ryan', 'C.', 'BSCS'),
(33, 'Placido', 'Paul Christian', 'S.', 'BSCS'),
(34, 'Progio', 'Dante', 'V.', 'BSCS'),
(35, 'Quinawayan', 'Marisa', 'A.', 'BSCS'),
(36, 'Reyes', 'Ramiel', 'E.', 'BSCS'),
(37, 'Santos', 'John Aeron', 'R.', 'BSCS'),
(38, 'Tinio', ' Angelito Miguel', 'N.', 'BSCS'),
(39, 'Villagonza', 'Shunn Gerold ', 'T.', 'BSCS');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_accounts`
--
ALTER TABLE `tbl_accounts`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbl_books`
--
ALTER TABLE `tbl_books`
  ADD PRIMARY KEY (`BookID`);

--
-- Indexes for table `tbl_borrowedbooks`
--
ALTER TABLE `tbl_borrowedbooks`
  ADD PRIMARY KEY (`TransactionID`);

--
-- Indexes for table `tbl_history`
--
ALTER TABLE `tbl_history`
  ADD PRIMARY KEY (`TransactionID`);

--
-- Indexes for table `tbl_students`
--
ALTER TABLE `tbl_students`
  ADD PRIMARY KEY (`StudentID`) USING BTREE;

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_accounts`
--
ALTER TABLE `tbl_accounts`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tbl_books`
--
ALTER TABLE `tbl_books`
  MODIFY `BookID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tbl_borrowedbooks`
--
ALTER TABLE `tbl_borrowedbooks`
  MODIFY `TransactionID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tbl_history`
--
ALTER TABLE `tbl_history`
  MODIFY `TransactionID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
