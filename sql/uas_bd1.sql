-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 26, 2022 at 12:03 PM
-- Server version: 8.0.30
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `uas_bd1`
--

-- --------------------------------------------------------

--
-- Table structure for table `accounts`
--

CREATE TABLE `accounts` (
  `id` int NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` text NOT NULL
);

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`id`, `username`, `password`) VALUES
(1, 'admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918'),
(2, 'root', 'root');

-- --------------------------------------------------------

--
-- Table structure for table `obat`
--

CREATE TABLE `obat` (
  `id` varchar(15) NOT NULL,
  `stok` int UNSIGNED NOT NULL,
  `satuan` varchar(20) NOT NULL,
  `harga` bigint UNSIGNED NOT NULL,
  `exp` date NOT NULL,
  `merek dagang` text NOT NULL
);

--
-- Dumping data for table `obat`
--

INSERT INTO `obat` (`id`, `stok`, `satuan`, `harga`, `exp`, `merek dagang`) VALUES
('A055', 6, 'Bottle', 10000, '2036-08-20', 'Naproxen'),
('UI011', 6, 'Bottle', 15000, '2036-08-20', 'Paracetamol');

-- --------------------------------------------------------

--
-- Table structure for table `obat_dalam_transaksi`
--

CREATE TABLE `obat_dalam_transaksi` (
  `id_transaksi` int NOT NULL,
  `id_obat` varchar(15) NOT NULL,
  `jlh` int UNSIGNED NOT NULL
);

--
-- Dumping data for table `obat_dalam_transaksi`
--

INSERT INTO `obat_dalam_transaksi` (`id_transaksi`, `id_obat`, `jlh`) VALUES
(2, 'A055', 1),
(5, 'A055', 3),
(7, 'A055', 2),
(8, 'A055', 2),
(10, 'A055', 1),
(14, 'A055', 1),
(15, 'A055', 1),
(16, 'A055', 1);

-- --------------------------------------------------------

--
-- Table structure for table `transaksi`
--

CREATE TABLE `transaksi` (
  `id_transaksi` int NOT NULL,
  `waktu_transaksi` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `nominal` bigint UNSIGNED NOT NULL
);

--
-- Dumping data for table `transaksi`
--

INSERT INTO `transaksi` (`id_transaksi`, `waktu_transaksi`, `nominal`) VALUES
(2, '2022-12-25 11:58:55', 28001),
(5, '2022-12-25 12:43:27', 38001),
(6, '2022-12-25 12:44:02', 10001),
(7, '2022-12-25 12:47:59', 20000),
(8, '2022-12-25 12:48:59', 20000),
(9, '2022-12-25 12:49:05', 20002),
(10, '2022-12-25 12:49:31', 38002),
(11, '2022-12-25 14:56:58', 20001),
(12, '2022-12-25 14:58:10', 10000),
(13, '2022-12-25 14:58:37', 20000),
(14, '2022-12-25 15:00:04', 10000),
(15, '2022-12-25 15:00:15', 28001),
(16, '2022-12-26 05:13:46', 24001),
(17, '2022-12-26 05:14:19', 24001);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accounts`
--
ALTER TABLE `accounts`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`),
  ADD UNIQUE KEY `username_2` (`username`);

--
-- Indexes for table `obat`
--
ALTER TABLE `obat`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `obat_dalam_transaksi`
--
ALTER TABLE `obat_dalam_transaksi`
  ADD KEY `id_obat` (`id_obat`),
  ADD KEY `id_transaksi` (`id_transaksi`);

--
-- Indexes for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`id_transaksi`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accounts`
--
ALTER TABLE `accounts`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `transaksi`
--
ALTER TABLE `transaksi`
  MODIFY `id_transaksi` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `obat_dalam_transaksi`
--
ALTER TABLE `obat_dalam_transaksi`
  ADD CONSTRAINT `obat_dalam_transaksi_ibfk_1` FOREIGN KEY (`id_obat`) REFERENCES `obat` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  ADD CONSTRAINT `obat_dalam_transaksi_ibfk_2` FOREIGN KEY (`id_transaksi`) REFERENCES `transaksi` (`id_transaksi`) ON DELETE RESTRICT ON UPDATE RESTRICT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
