-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 31, 2024 at 05:18 PM
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
-- Database: `dentalclinicc`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbladd`
--

CREATE TABLE `tbladd` (
  `pid` int(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `datebirth` date NOT NULL,
  `bloodtype` varchar(255) NOT NULL,
  `sex` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `mobilenumber` int(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `zip` int(255) NOT NULL,
  `nationality` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbladd`
--

INSERT INTO `tbladd` (`pid`, `name`, `datebirth`, `bloodtype`, `sex`, `email`, `mobilenumber`, `address`, `zip`, `nationality`) VALUES
(5, 'SDA', '2024-03-23', 'O+', 'Female', 'DSA', 423, 'CXZC', 34, 'SAD'),
(8, 'DDSA', '2024-03-23', 'O+', 'Male', 'ASDASD', 65, 'ASDSA', 3, 'ASDS'),
(9, 'DSAD', '2024-03-23', 'O-', 'Male', 'SADSAD', 9, 'SAD', 97, 'FDFDFF'),
(10, 'KELLLL', '2024-03-23', 'A-', 'Female', 'ASDSA', 86765, 'DFFDSDSHG', 987, 'DFDSFDS'),
(60, 'SADAD', '2024-03-23', 'O+', 'Female', 'DFSFSD', 9, 'DSADSDA', 12, 'ASDASD'),
(65, 'DSDF', '0000-00-00', 'O+', 'Female', 'SAD', 45, 'SAD', 7, 'DAD'),
(66, 'DSADS', '2024-03-23', 'O+', 'Female', 'DFD', 9, 'DSAD', 78, 'FDFS'),
(67, 'SDDSA', '2024-03-23', 'A-', 'Male', 'ASD', 23, 'SAD', 33, 'SAD'),
(89, 'MAYKEL', '2024-03-23', 'O-', 'Male', 'MAEKL', 9767, 'D', 234, 'SADSDS'),
(90, 'KEL', '2024-03-23', 'O+', 'Male', 'DSAD', 9, 'GSD', 9767, 'CDF'),
(6766, 'DSAD', '2024-03-23', 'O+', 'Male', 'ASDAD', 434, 'ASDSA', 34, 'SDSAD'),
(9898, 'SADSD', '2024-03-23', 'O+', 'Male', 'ASDSAD', 44, 'SAD', 44, 'DSAD');

-- --------------------------------------------------------

--
-- Table structure for table `tblapp`
--

CREATE TABLE `tblapp` (
  `aid` int(255) DEFAULT NULL,
  `name` varchar(255) NOT NULL,
  `appointment` varchar(255) NOT NULL,
  `date` date NOT NULL,
  `time` int(255) NOT NULL,
  `price` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbllogs`
--

CREATE TABLE `tbllogs` (
  `plid` int(255) DEFAULT NULL,
  `name` varchar(255) NOT NULL,
  `date` date NOT NULL,
  `injured` varchar(255) NOT NULL,
  `medicine` varchar(255) NOT NULL,
  `datework` date NOT NULL,
  `cost` int(255) NOT NULL,
  `description` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbllogs`
--

INSERT INTO `tbllogs` (`plid`, `name`, `date`, `injured`, `medicine`, `datework`, `cost`, `description`) VALUES
(78, 'ADS', '2024-03-23', 'Displaced Tooth', 'SADS', '2024-03-23', 89, 'SDV'),
(12, 'SADCA', '2024-03-23', 'CHipped Tooth', 'XS', '2024-03-23', 89, 'SACSA');

-- --------------------------------------------------------

--
-- Table structure for table `tblregister`
--

CREATE TABLE `tblregister` (
  `rid` int(255) NOT NULL,
  `admin` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblregister`
--

INSERT INTO `tblregister` (`rid`, `admin`, `email`, `username`, `password`) VALUES
(1, 'Kel', 'admin1', 'admin2', 'admin1'),
(2, 'ako', 'kel1', 'kel1', 'kel2'),
(3, 'ADMIN', 'kel', 'kel', 'kel'),
(4, 'kel', 'kel5', 'kel5', 'kel5'),
(5, 'kel', 'kel8', 'kel8', 'kel8'),
(6, 'MAYKELLLLL', 'MAYKEL', 'MAYKEL', 'MAYKEL'),
(7, 'MAYKELL', 'MAYKELL', 'MAYKELL', 'MAYKELL'),
(8, 'adminnnn', 'adminn', 'adminn', 'adminn'),
(9, 'ADMIN', 'ADMIN', 'ADMINN', 'ADMINN'),
(10, 'KEL', 'KEL23', 'KEL235', 'KEL234');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbladd`
--
ALTER TABLE `tbladd`
  ADD PRIMARY KEY (`pid`);

--
-- Indexes for table `tblregister`
--
ALTER TABLE `tblregister`
  ADD PRIMARY KEY (`rid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblregister`
--
ALTER TABLE `tblregister`
  MODIFY `rid` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
