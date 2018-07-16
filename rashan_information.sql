-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 16, 2018 at 08:42 PM
-- Server version: 10.3.8-MariaDB
-- PHP Version: 7.2.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `rashan_information`
--

-- --------------------------------------------------------

--
-- Table structure for table `display_area_information`
--

CREATE TABLE `display_area_information` (
  `Display_Area_Code` varchar(255) NOT NULL,
  `IsActive` tinyint(1) NOT NULL,
  `OwnerName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `fingerprint_data_information`
--

CREATE TABLE `fingerprint_data_information` (
  `Fingerprint_Code` varchar(255) NOT NULL,
  `Fingerprint_Name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `id_fingerprint_mapping`
--

CREATE TABLE `id_fingerprint_mapping` (
  `Id_No` int(11) NOT NULL,
  `Fingerprint_Code` varchar(255) NOT NULL,
  `Image_Path` varchar(4000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `mac_information`
--

CREATE TABLE `mac_information` (
  `Mac_Address` varchar(255) NOT NULL,
  `Passcode` varchar(255) NOT NULL,
  `IsActive` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `user_information`
--

CREATE TABLE `user_information` (
  `Id_No` int(11) NOT NULL,
  `Display_Area_Code` varchar(255) NOT NULL,
  `Mac_Address` varchar(255) NOT NULL,
  `Registration_No` varchar(255) NOT NULL,
  `Serial_No` varchar(255) NOT NULL,
  `Aadhar_No` varchar(255) NOT NULL,
  `Unique_No` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `display_area_information`
--
ALTER TABLE `display_area_information`
  ADD PRIMARY KEY (`Display_Area_Code`);

--
-- Indexes for table `fingerprint_data_information`
--
ALTER TABLE `fingerprint_data_information`
  ADD PRIMARY KEY (`Fingerprint_Code`);

--
-- Indexes for table `id_fingerprint_mapping`
--
ALTER TABLE `id_fingerprint_mapping`
  ADD KEY `fk_id_no_user_information` (`Id_No`),
  ADD KEY `fk_fingerprint_code_user_information` (`Fingerprint_Code`);

--
-- Indexes for table `mac_information`
--
ALTER TABLE `mac_information`
  ADD PRIMARY KEY (`Mac_Address`);

--
-- Indexes for table `user_information`
--
ALTER TABLE `user_information`
  ADD PRIMARY KEY (`Id_No`),
  ADD UNIQUE KEY `Display_Area_Code` (`Display_Area_Code`,`Registration_No`,`Serial_No`,`Mac_Address`) USING BTREE,
  ADD KEY `fk_mac_address_mac_table` (`Mac_Address`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `user_information`
--
ALTER TABLE `user_information`
  MODIFY `Id_No` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `id_fingerprint_mapping`
--
ALTER TABLE `id_fingerprint_mapping`
  ADD CONSTRAINT `fk_fingerprint_code_user_information` FOREIGN KEY (`Fingerprint_Code`) REFERENCES `fingerprint_data_information` (`Fingerprint_Code`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_id_no_user_information` FOREIGN KEY (`Id_No`) REFERENCES `user_information` (`Id_No`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Constraints for table `user_information`
--
ALTER TABLE `user_information`
  ADD CONSTRAINT `fk_display_area_code_display_table` FOREIGN KEY (`Display_Area_Code`) REFERENCES `display_area_information` (`Display_Area_Code`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_mac_address_mac_table` FOREIGN KEY (`Mac_Address`) REFERENCES `mac_information` (`Mac_Address`) ON DELETE NO ACTION ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
