-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versi server:                 10.1.16-MariaDB - mariadb.org binary distribution
-- OS Server:                    Win64
-- HeidiSQL Versi:               9.3.0.4984
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Dumping database structure for remun
DROP DATABASE IF EXISTS `remun`;
CREATE DATABASE IF NOT EXISTS `remun` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci */;
USE `remun`;


-- Dumping structure for table remun.t_dokumentasi
DROP TABLE IF EXISTS `t_dokumentasi`;
CREATE TABLE IF NOT EXISTS `t_dokumentasi` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `berkas` mediumblob,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='Tabel untuk menampung segala jenis berkas dokumentasi (Juknis, Rubrik, Manual, dll)';

-- Dumping data for table remun.t_dokumentasi: ~0 rows (approximately)
/*!40000 ALTER TABLE `t_dokumentasi` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_dokumentasi` ENABLE KEYS */;


-- Dumping structure for table remun.t_identitas
DROP TABLE IF EXISTS `t_identitas`;
CREATE TABLE IF NOT EXISTS `t_identitas` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `noSertifikat` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT 'khusus pendidik',
  `nip` varchar(19) COLLATE utf8_unicode_ci DEFAULT NULL,
  `nidn` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT 'khusus pendidik',
  `nama` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `jurusan` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `prodi` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `jabFung` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT 'selain jft dengan penamaan aneh mengisi "UMUM:',
  `tglLahir` date DEFAULT NULL,
  `tempatLhr` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `s1` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `s2` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `s3` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `jenis` varchar(3) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT 'khusus pendidik',
  `bidangIlmu` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `noHP` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `atasanLangsung` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `email` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `statusPK` bit(1) DEFAULT b'0' COMMENT '0 is Dosen',
  `statusDP` bit(1) DEFAULT b'1' COMMENT '1 is Dipakai',
  PRIMARY KEY (`id`),
  KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='Tabel yg menampung data identitas penginput remun';

-- Dumping data for table remun.t_identitas: ~5 rows (approximately)
/*!40000 ALTER TABLE `t_identitas` DISABLE KEYS */;
REPLACE INTO `t_identitas` (`id`, `noSertifikat`, `nip`, `nidn`, `nama`, `jurusan`, `prodi`, `jabFung`, `tglLahir`, `tempatLhr`, `s1`, `s2`, `s3`, `jenis`, `bidangIlmu`, `noHP`, `atasanLangsung`, `email`, `statusPK`, `statusDP`) VALUES
	(1, '123123123123', '199909092015031002', '12312312', 'S\'U\'dah', 'KEPERAWATAN', 'D4 KEPERAWATAN SOETOMO', 'asdasdasdad', '2018-04-27', 'adadadas', 'asdadad', 'sadas', 'asdasd', 'DS', 'asdadasda', '9861236193', 'asdasdas', 'asdadasd', b'0', b'1'),
	(2, '123123123', '123123123123123', '1231231231', 'daadaada', 'KEPERAWATAN', 'D4 KEPERAWATAN SOETOMO', 'adadasds', '2018-04-27', 'asdada', 'daad', 'asdasa', '-', 'DS', 'asdada', '234234234', 'dfsds', '234ffsdfsf', b'0', b'1'),
	(3, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
	(4, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
	(5, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
/*!40000 ALTER TABLE `t_identitas` ENABLE KEYS */;


-- Dumping structure for table remun.t_kampus
DROP TABLE IF EXISTS `t_kampus`;
CREATE TABLE IF NOT EXISTS `t_kampus` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `jenis` varchar(60) COLLATE utf8_unicode_ci NOT NULL COMMENT 'jenis perguruan tinggi',
  `nama` varchar(255) COLLATE utf8_unicode_ci NOT NULL COMMENT 'nama perguruan tinggi',
  `rektor` varchar(255) COLLATE utf8_unicode_ci NOT NULL COMMENT 'nama rektor/direktur',
  `fakultas` varchar(255) COLLATE utf8_unicode_ci NOT NULL COMMENT 'nama fakultas/Jurusan',
  `dekan` varchar(255) COLLATE utf8_unicode_ci NOT NULL COMMENT 'nama dekan/kajur',
  `jurusan` varchar(255) COLLATE utf8_unicode_ci NOT NULL COMMENT 'nama jurusan/prodi',
  `kajur` varchar(255) COLLATE utf8_unicode_ci NOT NULL COMMENT 'nama kajur/kaprodi',
  `logo` mediumblob NOT NULL COMMENT 'menyimpan logo',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='Tabel yang menampung identitas institusi/universitas.';

-- Dumping data for table remun.t_kampus: ~0 rows (approximately)
/*!40000 ALTER TABLE `t_kampus` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_kampus` ENABLE KEYS */;


-- Dumping structure for table remun.t_unsur
DROP TABLE IF EXISTS `t_unsur`;
CREATE TABLE IF NOT EXISTS `t_unsur` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tipeUnsur` int(2) NOT NULL COMMENT '1.Pendidikan pengajaran, 2.Penelitian, 3.Pengabmas, 4.Kegiatan Penunjang',
  `jenisKegiatan` varchar(500) COLLATE utf8_unicode_ci NOT NULL,
  `buktiPenugasan` varchar(500) COLLATE utf8_unicode_ci NOT NULL,
  `jamTarget` double NOT NULL,
  `masaPenugasan` varchar(500) COLLATE utf8_unicode_ci NOT NULL,
  `buktiDokumen` varchar(500) COLLATE utf8_unicode_ci NOT NULL,
  `jamCapaian` double NOT NULL,
  `rekomendasi` varchar(60) COLLATE utf8_unicode_ci NOT NULL COMMENT 'Tercapai, tidak tercapai, lebih',
  `bulan` int(2) NOT NULL,
  `tahun` int(4) NOT NULL,
  `tanggal` datetime NOT NULL,
  `tanggalUpdate` datetime DEFAULT NULL,
  `statusDP` bit(1) NOT NULL DEFAULT b'1',
  `idUser` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='Tabel untuk menampung seluruh kegiatan dosen. We put all record despite of Unsur into one single tabel. We hope this will do. If not we''ll going to split table into different table based on Unsur.';

-- Dumping data for table remun.t_unsur: ~6 rows (approximately)
/*!40000 ALTER TABLE `t_unsur` DISABLE KEYS */;
REPLACE INTO `t_unsur` (`id`, `tipeUnsur`, `jenisKegiatan`, `buktiPenugasan`, `jamTarget`, `masaPenugasan`, `buktiDokumen`, `jamCapaian`, `rekomendasi`, `bulan`, `tahun`, `tanggal`, `tanggalUpdate`, `statusDP`, `idUser`) VALUES
	(1, 1, '1', '1', 1, '1', '1', 1, 'TERCAPAI', 5, 2018, '2018-05-03 10:56:51', NULL, b'1', 1),
	(2, 1, '1', 'asd', 1, '1', '1', 1, 'TERCAPAI', 5, 2018, '2018-05-03 10:59:15', NULL, b'1', 1),
	(3, 1, 'asdas', '1', 1, '1', 'sad', 1, 'TERCAPAI', 5, 2018, '2018-05-03 10:59:27', NULL, b'1', 1),
	(4, 1, '1', 'sadd', 23, 'asd', 'asd', 123, 'TERCAPAI', 5, 2018, '2018-05-03 11:01:15', NULL, b'1', 1),
	(5, 1, 'asdasdas', 'asdsa', 1, 'asdasd', 'asdas', 1, 'TERCAPAI', 5, 2018, '2018-05-03 11:03:06', NULL, b'1', 1),
	(6, 1, 'asdasd', 'asdas', 1, 'asdas', 'asdasd', 1, 'TERCAPAI', 5, 2018, '2018-05-03 11:03:32', NULL, b'1', 1),
	(7, 1, 'sfsdfsd', 'sdfsd', 0.5, 'dgdfgd', 'dfg', 0.2, 'TIDAK TERCAPAI', 5, 2018, '2018-05-03 11:03:55', NULL, b'1', 1);
/*!40000 ALTER TABLE `t_unsur` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
