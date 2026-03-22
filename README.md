Instrukcja uruchomienia
1. Sklonować repozytorium: "git clone [LINK_DO_REPO]"
2. Otworzyć projekt w środowisku IDE
3. Skompilować i uruchomić projekt
4. Program automatycznie wykona demonstrację w konsoli.
 Struktura projektu
-Models (Folder Models): Tutaj znajdują się same szkielety danych.
-Użyłam klas abstrakcyjnych (Hardware, User), ponieważ nie ma sensu tworzyć "czystego" sprzętu – zawsze musi to być konkretny model.
-Dziedziczenie zastosowałam tam, gdzie wynika to z logiki biznesowej (np. Student i Pracownik to Użytkownicy, ale mają inne limity).
-Services (Folder Services): Klasa RentalService odpowiada za całą logikę. To tutaj sprawdzane są limity, dostępność sprzętu i liczone są kary.
-Program.cs: Pełni rolę prostego interfejsu. Nie ma tu logiki biznesowej – jedynie wywołania metod z serwisu i wyświetlanie wyników w konsoli.

Kohezja, Coupling 
-Wysoka Kohezja : Każda klasa robi jedną rzecz. Modele tylko przechowują dane, a RentalService zajmuje się tylko operacjami. Dzięki temu, jeśli zechcę zmienić sposób liczenia kary, muszę edytować tylko jedną metodę w serwisie, a nie cały projekt.
-Niski Coupling : Serwis nie musi wiedzieć, czy wypożycza Laptop czy Projector. Operuje na ogólnej klasie Hardware. Dzięki temu dodanie nowego typu sprzętu w przyszłości nie zepsuje logiki wypożyczania.

Reguły biznesowe
Limity: Student (2), Pracownik (5).
Kary: 10 PLN za każdy dzień po terminie.
Blokady: System nie pozwoli wypożyczyć sprzętu, który jest w serwisie (IsInService) lub jest już u innego użytkownika.
