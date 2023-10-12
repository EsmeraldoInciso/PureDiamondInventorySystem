-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 11, 2023 at 03:20 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_inventory_braga`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_brand`
--

CREATE TABLE `tbl_brand` (
  `BrandID` int(10) NOT NULL,
  `BrandName` varchar(50) NOT NULL,
  `IsActive` varchar(5) NOT NULL DEFAULT 'Yes'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_brand`
--

INSERT INTO `tbl_brand` (`BrandID`, `BrandName`, `IsActive`) VALUES
(1, 'Nestea', 'Yes'),
(2, 'Vita Herbs', 'Yes'),
(3, 'Bear Brand', 'Yes'),
(5, 'Sample brands', 'Yes');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_items`
--

CREATE TABLE `tbl_items` (
  `ItemID` int(10) NOT NULL,
  `ItemName` varchar(100) NOT NULL,
  `ItemPrice` varchar(20) NOT NULL DEFAULT '0.00',
  `ItemUOM` varchar(20) NOT NULL DEFAULT 'Pc',
  `BrandID` int(10) NOT NULL,
  `MinStock` int(10) NOT NULL DEFAULT 0,
  `ReorderQty` int(10) NOT NULL DEFAULT 0,
  `IsActive` varchar(5) NOT NULL DEFAULT 'Yes'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_items`
--

INSERT INTO `tbl_items` (`ItemID`, `ItemName`, `ItemPrice`, `ItemUOM`, `BrandID`, `MinStock`, `ReorderQty`, `IsActive`) VALUES
(1, 'NESTEA Milk Tea Winter\r\nMelon Pack of 2', '190.00', 'Pack/2s', 1, 100, 50, 'Yes'),
(3, 'Vita Herb Green Coffee 10', '500.00', 'Box/10s', 2, 100, 50, 'Yes');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_brand`
--
ALTER TABLE `tbl_brand`
  ADD PRIMARY KEY (`BrandID`);

--
-- Indexes for table `tbl_items`
--
ALTER TABLE `tbl_items`
  ADD PRIMARY KEY (`ItemID`),
  ADD KEY `BrandID` (`BrandID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_brand`
--
ALTER TABLE `tbl_brand`
  MODIFY `BrandID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tbl_items`
--
ALTER TABLE `tbl_items`
  MODIFY `ItemID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_items`
--
ALTER TABLE `tbl_items`
  ADD CONSTRAINT `tbl_items_ibfk_1` FOREIGN KEY (`BrandID`) REFERENCES `tbl_brand` (`BrandID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
