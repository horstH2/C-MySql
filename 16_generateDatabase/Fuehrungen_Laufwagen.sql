-- Datenbank Fuehrungen mit der Tabelle Laufwagen
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Fuehrungen` DEFAULT CHARACTER SET utf8 ;
USE `Fuehrungen` ;
-- -----------------------------------------------------
-- Table `Fuehrungen`.`Laufwagen`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Fuehrungen`.`Laufwagen` (
  `idBaureihe` CHAR(16) NOT NULL DEFAULT 'HGW',
  `idBaugroesse` CHAR(16) NULL DEFAULT '15CC',
  `H` INT NULL DEFAULT 24,
  `W` INT NULL DEFAULT 47,
  `L` DECIMAL(5,1) NULL DEFAULT 61.4,
  `Cdyn` INT NULL DEFAULT 11380,
  `C0` INT NULL DEFAULT 16970,
  PRIMARY KEY (`idBaureihe`))
ENGINE = InnoDB;