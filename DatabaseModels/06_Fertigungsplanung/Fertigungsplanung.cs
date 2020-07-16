-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema Fertigungsplanung
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `Fertigungsplanung` ;

-- -----------------------------------------------------
-- Schema Fertigungsplanung
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Fertigungsplanung` ;
USE `Fertigungsplanung` ;

-- -----------------------------------------------------
-- Table `Fertigungsplanung`.`Werkstuecke`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Fertigungsplanung`.`Werkstuecke` ;

CREATE TABLE IF NOT EXISTS `Fertigungsplanung`.`Werkstuecke` (
  `idWSt` INT UNSIGNED ZEROFILL NOT NULL,
  `Werkstueck` VARCHAR(60) NULL DEFAULT 'WSt',
  `Bearbeiter` VARCHAR(80) NULL DEFAULT 'Bearbeiter',
  `Zeichnung` BLOB NULL DEFAULT NULL,
  PRIMARY KEY (`idWSt`),
  UNIQUE INDEX `idWSt_UNIQUE` (`idWSt` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Fertigungsplanung`.`Arbeitsplaene`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Fertigungsplanung`.`Arbeitsplaene` ;

CREATE TABLE IF NOT EXISTS `Fertigungsplanung`.`Arbeitsplaene` (
  `idWSt` INT UNSIGNED NOT NULL,
  `idAV` INT UNSIGNED NOT NULL,
  `Arbeitsvorgang` VARCHAR(80) NULL,
  `Arbeitsplatz` VARCHAR(45) NULL,
  `Spannung` VARCHAR(45) NULL,
  `tr` DECIMAL(6,3) ZEROFILL NULL,
  `te` DECIMAL(6,3) ZEROFILL NULL,
  `tu` DECIMAL(6,3) ZEROFILL NULL,
  PRIMARY KEY (`idWSt`, `idAV`),
  CONSTRAINT `fk_Arbeitsplaene_Werkstuecke`
    FOREIGN KEY (`idWSt`)
    REFERENCES `Fertigungsplanung`.`Werkstuecke` (`idWSt`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
