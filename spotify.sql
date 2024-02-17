
SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `spotify`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `tracks`
--

CREATE TABLE `tracks` (
  `Place` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Artists` varchar(50) NOT NULL,
  `Album` varchar(50) NOT NULL
)ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
COMMIT;

CREATE TABLE `artists_origin` (
  `artistname` varchar(50) NOT NULL,
  `country` varchar(50) NOT NULL
)ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
COMMIT; 

INSERT INTO artists_origin (artistname, country)
VALUES
  ('RAYE', 'Wielka Brytania'),
  ('070 Shake', 'USA'),
  ('The Weeknd', 'Kanada'),
  ('Miguel', 'USA'),
  ('Central Cee', 'Wielka Brytania'),
  ('Headie One', 'Wielka Brytania'),
  ('Sam Smith', 'Wielka Brytania'),
  ('Kim Petras', 'Niemcy'),
  ('David Guetta', 'Francja'),
  ('venbee', 'Wielka Brytania'),
  ('goddard.', 'Wielka Brytania'),
  ('Oliver Tree', 'USA'),
  ('Robin Schulz', 'Niemcy'),
  ('OneRepublic', 'USA'),
  ('Rema', 'Nigeria'),
  ('Meghan Trainor', 'USA'),
  ('Bugzy Malone', 'Wielka Brytania'),
  ('TeeDee', 'Wielka Brytania'),
  ('Tate McRae', 'Kanada'),
  ('Sabrina Carpenter', 'USA'),
  ('Beyoncé', 'USA'),
  ('Anne-Marie', 'Wielka Brytania'),
  ('Aitch', 'Wielka Brytania'),
  ('Future', 'USA'),
  ('Chris Brown', 'USA'),
  ('JVKE', 'USA'),
  ('Eliza Rose', 'Wielka Brytania'),
  ('Interplanetary Criminal', 'Wielka Brytania'),
  ('The Neighbourhood', 'USA'),
  ('Skrillex', 'USA'),
  ('Fred again..', 'Wielka Brytania'),
  ('Flowdan', 'Wielka Brytania'),
  ('Mimi Webb', 'Wielka Brytania'),
  ('Arctic Monkeys', 'Wielka Brytania'),
  ('Tory Lanez', 'Kanada'),
  ('d4vd', 'USA'),
  ('LF SYSTEM', 'Szkocja'),
  ('Eminem', 'USA'),
  ('Coi Leray', 'USA'),
  ('Cian Ducrot', 'Irlandia'),
  ('Stormzy', 'Wielka Brytania'),
  ('Popcaan', 'Jamajka'),
  ('Käärijä', 'Finlandia'),
('BLANKA', 'Polska'),
('David Kushner', 'USA'),
('Kizo', 'Polska'),
('Bletka', 'Polska'),
('Eddie Block', 'Polska'),
('Adash', 'Polska'),
('Alessandra', 'Polska'),
('Gruby Mielzky', 'Polska'),
('Borixon', 'Polska'),
('BeMelo', 'Polska'),
('Szpaku', 'Polska'),
('Przemek.pro', 'Polska'),
('Qry', 'Polska'),
('Bartek Kubicki', 'Polska'),
('Trzech Króli', 'Polska'),
('Måneskin', 'Włochy'),
('Tom Morello', 'USA'),
('Miley Cyrus', 'USA'),
('Białas', 'Polska'),
('Sobel', 'Polska'),
('Deemz', 'Polska'),
('2115', 'Polska'),
('Bedoes', 'Polska'),
('White 2115', 'Polska'),
('Taco Hemingway', 'Polska'),
('Noa Kirel', 'Izrael'),
('Wroobel', 'Polska'),
('Słoń', 'Polska'),
('Young Leosia', 'Polska'),
('Dwa Sławy', 'Polska'),
('Jann', 'Polska'),
('Cyrko', 'Polska'),
('Favst', 'Polska'),
('Kuban', 'Polska'),
('Quebonafide', 'Polska'),
('Smolasty', 'Polska'),
('WIKTOR', 'Polska'),
('Jakub Laszuk', 'Polska'),
('sanah', 'Polska'),
('FAST BOY', 'Polska'),
('Topic', 'Polska'),
('Gibbs', 'Polska'),
('Kiełas', 'Polska'),
('ReTo', 'Polska'),
('Kubi Producent', 'Polska'),
('Guzior', 'Polska'),
('Daria Zawiałow', 'Polska'),
('Waima', 'Polska'),
('Mjonszu', 'Polska'),
('Joker Out', 'Polska'),
('Janusz Walczuk', 'Polska'),
('clearmind', 'Polska'),
('Worek', 'Polska'),
('Kubańczyk', 'Polska'),
('Tribbs', 'Polska'),
('club2020', 'Polska'),
('Otsochodzi', 'Polska'),
('Oki', 'Polska'),
('Young Igi', 'Polska'),
('schafter', 'Polska'),
('@atutowy', 'Polska'),
('Selena Gomez', 'USA'),
('Popek', 'Polska'),
('Matheo', 'Polska'),
('Vito Bambino', 'Polska'),
('Dawid Podsiadło', 'Polska'),
('Miszel', 'Polska'),
('Kabe', 'Polska'),
('Premixm', 'Polska'),
('21 Savage', 'Wielka Brytania'),
('Matlane', 'Polska'),
('Grew', 'Polska'),
('La Zarra', 'Francja'),
('Eslabon Armado', 'Meksyk'),
('Morgan Wallen', 'USA'),
('Lil Durk', 'USA'),
('Grupo Frontera', 'Portoryko'),
('Tyler, The Creator', 'USA'),
('FIFTY FIFTY', 'Korea'),
('Yng Lvcas', 'Meksyk'),
('Lil Mabu', 'USA'),
('Kali', 'Polska'),
('Luke Combs', 'USA'),
('NLE Choppa', 'USA'),
('Natanael Cano', 'Meksyk'),
('Peso Pluma', 'Meksyk'),
('Junior H', 'Meksyk'),
('Zach Bryan', 'USA'),
('Harry Styles', 'Wielka Brytania'),
('Chino Pacas', 'Meksyk'),
('Steve Lacy', 'USA'),
('Kendrick Lamar', 'USA'),
('Jay Rock', 'USA'),
('Nicki Minaj', 'Trinidad i Tobago'),
('Lil Uzi Vert', 'USA'),
('Loreen', 'Szwecja'),
('Calvin Harris', 'Wielka Brytania'),
('Ellie Goulding', 'Wielka Brytania'),
('PinkPantheress', 'Wielka Brytania'),
('Ice Spice', 'Wielka Brytania'),
('Libianca', 'Niemcy'),
('SZA', 'USA'),
('Lewis Capaldi', 'Wielka Brytania'),
('Ed Sheeran', 'Wielka Brytania'),
('Taylor Swift', 'USA'),
('Jazzy', 'USA'),
('Switch Disco', 'Wielka Brytania'),
('Ella Henderson', 'Wielka Brytania'),
('Robert Miles', 'Włochy'),
('Post Malone', 'USA'),
('Kali Uchis', 'USA'),
('Lizzy McAlpine', 'USA'),
('Florence + The Machine', 'Wielka Brytania'),
('J. Cole', 'USA'),
('Mae Muller', 'Wielka Brytania'),
('Metro Boomin', 'USA'),
('Bakar', 'Wielka Brytania'),
('Mae Stephens', 'USA'),
('The Killers', 'USA'),
('Bebe Rexha', 'USA'),
('Tom Odell', 'Wielka Brytania'),
('Drake', 'Kanada'),
('Yung Yury', 'Rosja'),
('Damn Yury', 'Rosja'),
('Udo Lindenberg', 'Niemcy'),
('Apache 207', 'Niemcy'),
('reezy', 'Niemcy'),
('Luciano', 'Niemcy'),
('Ikke Hüftgold', 'Niemcy'),
('Schürze', 'Niemcy'),
('DJ Robin', 'Niemcy'),
('RAF Camora', 'Austria'),
('HoodBlaq', 'Niemcy'),
('01099', 'Niemcy'),
('Paul', 'Niemcy'),
('Ski Aggu', 'Niemcy'),
('Bonez MC', 'Niemcy'),
('Gzuz', 'Niemcy'),
('Nimo', 'Niemcy'),
('Tiësto', 'Holandia'),
('Julian Sommer', 'Niemcy'),
('Mia Julia', 'Niemcy'),
('Nina Chuba', 'Niemcy'),
('Samra', 'Niemcy'),
('AYLIVA', 'Niemcy'),
('MERO', 'Niemcy'),
('Peter Fox', 'Niemcy'),
('Inéz', 'Niemcy');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;