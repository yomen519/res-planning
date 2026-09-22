# Checklist przygotowania demo — Research Planner

> Demo Unity bez serwera PHP. Login: **Janusz** / **1234**  
> Szacowany czas demo na żywo: **8 minut**

---

## Tydzień przed prezentacją

- [ ] Zainstaluj **Unity Hub** i edytor **Unity 2022.3.62f3** (lub najbliższą wersję 2022.3 LTS)
- [ ] Sklonuj / otwórz projekt: `C:\Users\konra\projects\res-planning\ZarzProj`
- [ ] Pierwsze otwarcie — poczekaj na import assetów (może potrwać 5–15 min)
- [ ] Uruchom scenę `Assets/Scenes/SampleScene.unity` i sprawdź, czy projekt się kompiluje
- [ ] Przećwicz pełny scenariusz demo minimum **3 razy**
- [ ] Zrób nagranie ekranu (backup) na wypadek problemów technicznych

---

## Dzień przed prezentacją

- [ ] Uruchom demo jeszcze raz na **tym samym komputerze**, na którym będzie prezentacja
- [ ] Sprawdź rozdzielczość ekranu — Unity Game View ustaw na **1920×1080** lub Full HD
- [ ] Zamknij zbędne aplikacje (Discord, przeglądarka z wieloma kartami)
- [ ] Wyłącz powiadomienia systemowe (Windows: Tryb skupienia)
- [ ] Naładuj laptop / podłącz zasilanie
- [ ] Przygotuj kopię zapasową: nagranie wideo lub zrzuty ekranu kluczowych kroków

---

## Godzinę przed prezentacją

- [ ] Otwórz Unity z projektem `ZarzProj`
- [ ] Otwórz scenę: `Assets/Scenes/SampleScene.unity`
- [ ] Kliknij **Play** i zaloguj się (`Janusz` / `1234`) — potwierdź, że działa
- [ ] Kliknij **Stop** — zostaw Unity otwarte, scenę załadowaną
- [ ] Przygotuj w drugim oknie (lub na drugim monitorze):
  - `AnalizaWymagan.md` — do slajdów o wymaganiach
  - `diagramy/aktor-opiekun.png` — diagram UML
- [ ] Sprawdź kabel HDMI / adapter do projektora

---

## Scenariusz demo krok po kroku

### Krok 1 — Uruchomienie (30 s)

1. W Unity upewnij się, że aktywna jest scena `SampleScene`
2. Kliknij przycisk **Play** (trójkąt u góry)
3. Powiedz: *„Uruchamiamy prototyp interfejsu Research Planner”*

### Krok 2 — Logowanie (1 min)

1. Na ekranie logowania wpisz:
   - Login: `Janusz`
   - Hasło: `1234`
2. Kliknij przycisk logowania
3. Powiedz: *„System weryfikuje użytkownika — w prototypie mamy też integrację z backendem PHP”*

> **Uwaga:** Login `Janusz`/`1234` działa **bez serwera** (bypass w `ASUPro_Core.cs`). Nie próbuj innych kont bez skonfigurowanego PHP.

### Krok 3 — Członkowie zespołu (1 min)

1. Pokaż listę członków zespołu (domyślnie: Janusz)
2. Powiedz: *„Każdy członek zespołu może być przypisany do zadań — zgodnie z rolą Członek zespołu z analizy wymagań”*

### Krok 4 — Dodanie paska zadań (1 min)

1. Kliknij przycisk dodawania nowego paska zadań (w panelu zadań)
2. Pokaż, że pasek ma losowy kolor — wizualna organizacja etapów
3. Powiedz: *„Paski reprezentują etapy lub kategorie prac w projekcie”*

### Krok 5 — Dodanie zadania (1,5 min)

1. Na nowym pasku kliknij dodaj zadanie
2. Kliknij zadanie, aby otworzyć konfigurator
3. Wypełnij przykładowe dane:
   - **Nazwa:** „Przegląd literatury”
   - **Opis:** „Analiza publikacji z ostatnich 5 lat”
   - **Termin:** np. `2026-03-15`
4. Zapisz zmiany
5. Powiedz: *„Kierownik projektu definiuje zadania z terminem i opisem”*

### Krok 6 — Przypisanie osoby (1 min)

1. W konfiguratorze przypisz użytkownika (Janusz) do zadania
2. Pokaż, że nazwa pojawia się na karcie zadania
3. Powiedz: *„Lider zespołu deleguje zadania konkretnym osobom”*

### Krok 7 — Drag & drop (1,5 min)

1. Utwórz drugi pasek zadań (jeśli jeszcze nie ma)
2. Przeciągnij zadanie z jednego paska do drugiego
3. Powiedz: *„Zadania można reorganizować między etapami — np. po zmianie priorytetów w projekcie”*

### Krok 8 — Zakończenie demo (30 s)

1. Kliknij **Stop** w Unity
2. Powiedz: *„To prototyp UI — kolejnym krokiem jest zapis do bazy i moduły budżetowe oraz raportowe”*

---

## Co powiedzieć, jeśli coś nie działa

| Problem | Reakcja |
|---------|---------|
| Unity się nie kompiluje | Pokaż nagranie wideo z backupu |
| Błąd przy logowaniu | Użyj dokładnie `Janusz` / `1234` (wielkość liter ma znaczenie) |
| Drag & drop nie reaguje | Kliknij zadanie i przeciągnij za nagłówek/kartę; odśwież Play |
| Konfigurator się nie otwiera | Kliknij bezpośrednio na kartę zadania |
| Brak czasu na demo | Pokaż nagranie + slajd 8 (co zaimplementowano) |

---

## Czego NIE pokazywać na demo

- [ ] Logowanie przez PHP (wymaga XAMPP + konfiguracji `Config.php`)
- [ ] Rejestrację nowego użytkownika (backend nie jest skonfigurowany)
- [ ] Pliki `GetScores.cs` / `InsertScore.cs` (to pozostałości tutoriala, nie część RP)
- [ ] Moduły budżetowe, raporty, Gantt — **nie istnieją w kodzie**

---

## Konfiguracja Unity — ustawienia zalecane

```
Game View: 1920 x 1080
Scale: 1x (lub dopasuj do projektora)
Maximize on Play: opcjonalnie (wygodniejsze na prezentacji)
```

**Ścieżki w projekcie:**

| Element | Ścieżka |
|---------|---------|
| Projekt Unity | `ZarzProj/` |
| Główna scena | `ZarzProj/Assets/Scenes/SampleScene.unity` |
| Scena logowania (asset) | `ZarzProj/Assets/ASUPro/Scene/Login.unity` |
| Login demo | `Janusz` / `1234` |

---

## Opcjonalnie: demo z PHP (zaawansowane)

> Tylko jeśli masz czas i doświadczenie. **Nie jest wymagane** na prezentacji.

1. Zainstaluj XAMPP (Apache + MySQL)
2. Skopiuj `Login.php`, `Register.php`, `Config.php` do `htdocs/ASUPro/`
3. Uzupełnij `Config.php` (host, baza, tabela)
4. Zaimportuj `asupro.sql` do phpMyAdmin
5. W Unity ustaw URL w `ASUPro_Core.cs`: `http://127.0.0.1/ASUPro/`
6. Zarejestruj konto → zaloguj bez bypassu `Janusz`

**Uwaga:** PHP używa przestarzałego API `mysql_*` — może nie działać na PHP 7+.

---

## Szybka lista kontrolna — 5 min przed startem

```
[ ] Unity otwarte, SampleScene załadowana
[ ] Play → Janusz/1234 → działa
[ ] Stop — gotowe do ponownego Play na prezentacji
[ ] Backup wideo dostępny
[ ] Slajdy / PDF otwarte w tle
[ ] Powiadomienia wyłączone
[ ] Laptop na zasilaniu
```

---

## Materiały do pokazania obok demo (bez uruchamiania)

| Plik | Kiedy pokazać |
|------|---------------|
| `KartaProjektu.md` | Wprowadzenie, zakres |
| `AnalizaWymagan.md` | Role interesariuszy |
| `diagramy/aktor-opiekun.png` | Diagram UML |
| `image-6.png`, `image-7.png` | Diagramy Kierownik / Lider |
| `Raport zamknięcia projektu.pdf` | Podsumowanie końcowe |
