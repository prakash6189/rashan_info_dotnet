-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 21, 2018 at 06:24 PM
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
('3214', 1, '789654', '1', '1', 'temp1'),
('4514', 1, '7895', '1', '1', ''),
('55555', 1, '88888', '1', '2', 'temp'),
('578541', 3, '7596', '1', '5', ''),
('6220', 3, '20120', '2', '1', 'prakash'),
('6320', 3, '20120', '1', '1', ''),
('6440', 1, '555555', '1', '1', 'sunny');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `user_information`
--
ALTER TABLE `user_information`
  ADD PRIMARY KEY (`Aadhar_No`),
  ADD UNIQUE KEY `Mac_Display_Id` (`Mac_Display_Id`,`Registration_No`,`Serial_No`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `user_information`
--
ALTER TABLE `user_information`
  ADD CONSTRAINT `fk_mac_display_id_user_inf` FOREIGN KEY (`Mac_Display_Id`) REFERENCES `mac_display_mapping` (`Mac_Display_Id`) ON DELETE NO ACTION ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
