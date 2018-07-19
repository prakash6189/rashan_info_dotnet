-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 19, 2018 at 05:40 AM
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
-- Table structure for table `aadhar_fingerprint_mapping`
--

CREATE TABLE `aadhar_fingerprint_mapping` (
  `Aadhar_No` varchar(255) NOT NULL,
  `Fingerprint_Code` varchar(255) NOT NULL,
  `Image_Path` varchar(4000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `display_area_information`
--

CREATE TABLE `display_area_information` (
  `Display_Area_Code` varchar(255) NOT NULL,
  `IsActive` tinyint(1) NOT NULL,
  `OwnerName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `display_area_information`
--

INSERT INTO `display_area_information` (`Display_Area_Code`, `IsActive`, `OwnerName`) VALUES
('110995', 1, 'kashyap'),
('281194', 1, 'prakash');

-- --------------------------------------------------------

--
-- Table structure for table `fingerprint_data_information`
--

CREATE TABLE `fingerprint_data_information` (
  `Fingerprint_Code` varchar(255) NOT NULL,
  `Fingerprint_Name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `fingerprint_data_information`
--

INSERT INTO `fingerprint_data_information` (`Fingerprint_Code`, `Fingerprint_Name`) VALUES
('l1', 'left thumb'),
('l2', 'left index'),
('l3', 'left middle'),
('l4', 'left ring'),
('l5', 'left baby'),
('r1', 'right thumb'),
('r2', 'right index'),
('r3', 'right middle'),
('r4', 'right ring'),
('r5', 'right baby');

-- --------------------------------------------------------

--
-- Table structure for table `mac_display_mapping`
--

CREATE TABLE `mac_display_mapping` (
  `Mac_Display_Id` int(11) NOT NULL,
  `Mac_Address` varchar(255) NOT NULL,
  `Display_Area_Code` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mac_display_mapping`
--

INSERT INTO `mac_display_mapping` (`Mac_Display_Id`, `Mac_Address`, `Display_Area_Code`) VALUES
(3, '00FF43FE68D1', '110995'),
(1, '00FF43FE68D1', '281194');

-- --------------------------------------------------------

--
-- Table structure for table `mac_information`
--

CREATE TABLE `mac_information` (
  `Mac_Address` varchar(255) NOT NULL,
  `Passcode` varchar(255) NOT NULL,
  `IsActive` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mac_information`
--

INSERT INTO `mac_information` (`Mac_Address`, `Passcode`, `IsActive`) VALUES
('00FF43FE68D1', '9428429715', 1);

-- --------------------------------------------------------

--
-- Table structure for table `user_information`
--

CREATE TABLE `user_information` (
  `Aadhar_No` varchar(255) NOT NULL,
  `Mac_Display_Id` int(11) NOT NULL,
  `Registration_No` varchar(255) NOT NULL,
  `Serial_No` varchar(255) NOT NULL,
  `Unique_No` varchar(255) NOT NULL,
  `Name` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user_information`
--

INSERT INTO `user_information` (`Aadhar_No`, `Mac_Display_Id`, `Registration_No`, `Serial_No`, `Unique_No`, `Name`) VALUES
('6220', 3, '20120', '2', '1', 'prakash');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `aadhar_fingerprint_mapping`
--
ALTER TABLE `aadhar_fingerprint_mapping`
  ADD KEY `fk_aadhar_no_user_info_Table` (`Aadhar_No`);

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
-- Indexes for table `mac_display_mapping`
--
ALTER TABLE `mac_display_mapping`
  ADD PRIMARY KEY (`Mac_Display_Id`),
  ADD UNIQUE KEY `Mac_Address` (`Mac_Address`,`Display_Area_Code`),
  ADD KEY `fk_display_area_code_mac_display_table` (`Display_Area_Code`);

--
-- Indexes for table `mac_information`
--
ALTER TABLE `mac_information`
  ADD PRIMARY KEY (`Mac_Address`);

--
-- Indexes for table `user_information`
--
ALTER TABLE `user_information`
  ADD PRIMARY KEY (`Aadhar_No`),
  ADD UNIQUE KEY `Mac_Display_Id` (`Mac_Display_Id`,`Registration_No`,`Serial_No`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `mac_display_mapping`
--
ALTER TABLE `mac_display_mapping`
  MODIFY `Mac_Display_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `aadhar_fingerprint_mapping`
--
ALTER TABLE `aadhar_fingerprint_mapping`
  ADD CONSTRAINT `fk_aadhar_no_user_info_Table` FOREIGN KEY (`Aadhar_No`) REFERENCES `user_information` (`Aadhar_No`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Constraints for table `mac_display_mapping`
--
ALTER TABLE `mac_display_mapping`
  ADD CONSTRAINT `fk_display_area_code_mac_display_table` FOREIGN KEY (`Display_Area_Code`) REFERENCES `display_area_information` (`Display_Area_Code`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_mac_address_mac_display_table` FOREIGN KEY (`Mac_Address`) REFERENCES `mac_information` (`Mac_Address`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Constraints for table `user_information`
--
ALTER TABLE `user_information`
  ADD CONSTRAINT `fk_mac_display_id_user_inf` FOREIGN KEY (`Mac_Display_Id`) REFERENCES `mac_display_mapping` (`Mac_Display_Id`) ON DELETE NO ACTION ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
