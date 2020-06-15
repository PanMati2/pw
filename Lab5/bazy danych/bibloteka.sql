-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 14 Cze 2020, 23:09
-- Wersja serwera: 10.4.11-MariaDB
-- Wersja PHP: 7.2.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `bibloteka`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `ksiazki`
--

CREATE TABLE `ksiazki` (
  `ID` bigint(20) UNSIGNED NOT NULL,
  `tytul` text NOT NULL,
  `autor` text NOT NULL,
  `rok_wydania` int(11) NOT NULL,
  `gatunek` text NOT NULL,
  `ilosc` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `ksiazki`
--

INSERT INTO `ksiazki` (`ID`, `tytul`, `autor`, `rok_wydania`, `gatunek`, `ilosc`) VALUES
(1, 'Pan Tadeusz', 'Adam Mickiewicz', 1834, 'Poezja epicka', 23),
(2, 'Szklany tron', 'Sarah J. Maas', 2012, 'Fantasy', 6),
(3, 'Cztery pory roku', 'Stephen King', 1982, 'zbiór opowiadań', 55),
(4, 'Harry Potter i Kamień Filozoficzny', 'J.K. Rowling', 1997, 'Fantasy', 0),
(5, 'Skazani na Shawshank', 'Stephen King', 1982, 'Horror', 0),
(6, 'Zielona mila', 'Stephen King', 1996, 'Horror', 3);

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `ksiazki`
--
ALTER TABLE `ksiazki`
  ADD UNIQUE KEY `ID` (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT dla tabeli `ksiazki`
--
ALTER TABLE `ksiazki`
  MODIFY `ID` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
