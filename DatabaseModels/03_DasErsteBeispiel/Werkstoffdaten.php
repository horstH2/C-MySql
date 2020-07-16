-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema Werkstoffdaten
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Werkstoffdaten
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Werkstoffdaten` DEFAULT CHARACTER SET utf8 ;
USE `Werkstoffdaten` ;

-- -----------------------------------------------------
-- Table `Werkstoffdaten`.`Werkstoffe`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Werkstoffdaten`.`Werkstoffe` (
  `idWerkstoffe` VARCHAR(20) NOT NULL DEFAULT '1.1191',
  `Bezeichnung` VARCHAR(20) NULL DEFAULT 'Ck45',
  `kc11` INT NULL DEFAULT 2220,
  `m` DECIMAL(10,3) NULL DEFAULT 0.140,
  `Rp0,2` INT NULL DEFAULT 430,
  `Rm` INT NULL DEFAULT 700,
  `Bemerkung` VARCHAR(80) NULL DEFAULT 'vergütet' COMMENT 'Beschreibung:   	Werkstoffte\nWerkstoffnummer	\nBezeichnung	\nSpezifische Schnittkraft	k_c1.1    in N/mm²\nAnstiegswert	                m\nDehngrenze	                R_p0,2    in N/mm²\nZugfestigkeit	                R_m         in N/mm²\nBemerkung	\n',
  PRIMARY KEY (`idWerkstoffe`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
