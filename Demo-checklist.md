# Checklist przygotowania demo — Research Planner

> Prezentacja gotowej aplikacji: **pokazać, że działa** + **pokazać kod źródłowy** + pytania z sali.  
> Szacowany czas demo na żywo: **5–8 minut** + pokaz kodu **3–5 minut**

---

## Jak uruchomić aplikację

**Opcja A — gotowy plik `.exe` (zalecana na prezentację)**

Aktualna wersja: **v1.1** ([Releases → v1.1-prezentacja](https://github.com/yomen519/res-planning/releases/tag/v1.1-prezentacja)) — poprawione skalowanie interfejsu, tablica dopasowuje się do rozmiaru okna.

Aplikacja zbudowana z Unity 2022.3.62f3 jako program dla Windows (ok. 74 MB):

```
ResearchPlanner-exe\ResearchPlanner.exe   ← dwuklik
```

- Kopiuj **cały folder** `ResearchPlanner-exe` (razem z `ResearchPlanner_Data`, `UnityPlayer.dll`, `MonoBleedingEdge`) — sam plik `.exe` nie zadziała.
- Nie wymaga instalacji Unity ani internetu.
- Plik `.exe` **nie jest w repozytorium** (`.gitignore` wyklucza buildy). Budowanie: Unity 2022.3.62f3 → `File → Build Settings` → scena `Assets/Scenes/SampleScene.unity` → `Build`.

**Opcja B — edytor Unity (zapasowa)**

1. Unity Hub → `Add project from disk` → folder `ZarzProj` (edytor **2022.3.62f3** — nie otwieraj w Unity 6, bo zaproponuje upgrade projektu)
2. `Assets/Scenes/SampleScene.unity` → dwuklik
3. **Play ▶** → zakładka **Game**

---

## Dzień przed prezentacją

- [ ] Uruchom `ResearchPlanner.exe` na **tym samym komputerze**, na którym będzie prezentacja
- [ ] Przejdź pełny scenariusz demo **2–3 razy**
- [ ] Nagraj demo jako backup (Windows: **Win + Alt + R** — nagrywanie ekranu Xbox Game Bar)
- [ ] Otwórz w Cursorze / VS Code folder `ZarzProj/Assets/Scripts` — do pokazu kodu
- [ ] Wyłącz powiadomienia systemowe (Windows: Tryb skupienia)
- [ ] Naładuj laptop / podłącz zasilanie

---

## Scenariusz demo krok po kroku

> Aplikacja startuje **od razu na tablicy zadań** „TASKbar ORGANIZER 5000” — **nie ma ekranu logowania** w zbudowanej wersji.

### Krok 1 — Uruchomienie (30 s)

1. Dwuklik `ResearchPlanner.exe` — okno „Research Planner”
2. Powiedz: *„To prototyp interfejsu Research Planner — tablica etapów i zadań projektu.”*

### Krok 2 — Etapy projektu (1,5 min)

1. Kliknij **ADD TASK BAR** (lewy górny róg) — **dwa razy**
2. Pojawiają się dwa paski w losowych kolorach
3. Kliknij pole **„Change name:”** na pierwszym pasku, wpisz `Analiza`, zatwierdź Enterem
4. To samo na drugim pasku: `Realizacja`
5. Powiedz: *„Paski reprezentują etapy projektu — nazwy nadaję bezpośrednio na tablicy.”*

### Krok 3 — Nowe zadanie (1,5 min)

1. Na pasku kliknij **NEW TASK** — pojawia się karta z polami `title:` i `users:`
2. **Kliknij w kartę** — otwiera się edytor zadania: `title`, `Task Content`, `Assign Person`, `files`
3. Wpisz **krótki** tytuł, np. `Analiza` (długie tytuły nachodzą na nazwę osoby na karcie)
4. Opcjonalnie wpisz treść w polu **Task Content**
5. Powiedz: *„Kierownik projektu definiuje zadanie w ramach etapu.”*

### Krok 4 — Przypisanie osoby (1 min)

1. W edytorze kliknij **+** pod „Assign Person”
2. W oknie **ADD PERSON** kliknij kartę **Janusz**, zamknij okno **X**
3. Kliknij **czerwoną dyskietkę** (prawy górny róg edytora) — zapis
4. Na karcie zadania widać tytuł i „Janusz”
5. Powiedz: *„Lider zespołu deleguje zadanie konkretnej osobie.”*

### Krok 5 — Drag & drop (1 min)

1. Przytrzymaj kartę zadania i **przeciągnij na drugi pasek** — prowadź mysz **spokojnie**, przy gwałtownym ruchu karta wraca na miejsce
2. Karta przyjmuje kolor nowego paska
3. Powiedz: *„Zadania można przenosić między etapami, gdy zmieniają się priorytety.”*

### Krok 6 — Zakończenie (30 s)

1. Zamknij okno aplikacji
2. Powiedz: *„To prototyp UI — dane są tylko w pamięci, po zamknięciu znikają. Kolejny krok to zapis do bazy.”*

---

## Pokaz kodu źródłowego (3–5 min)

Otwórz `ZarzProj/Assets/` w Cursorze / VS Code albo na GitHubie. Kod ma komentarze (dodane w commicie „Added comments”, kwiecień 2026).

| Plik | Co pokazać | Linie |
|------|-----------|-------|
| `TaskBar.cs` | `Awake()` — losowy kolor paska; `AddNewTask()` — tworzenie karty z prefabu | cały plik (46 linii) |
| `Scripts/TaskCell.cs` | Model zadania: `content`, `endDate`, `assignedPlayer`; `SetTaskCell()` | pola na górze |
| `Scripts/TaskConfigurator.cs` | `ImportTask()` — wczytanie karty do edytora; `SaveCurrentTask()` — zapis | środek pliku |
| `Scripts/Dragme.cs` | `OnBeginDrag()` / `OnEndDrag()` / `GetClosestObject()` — przyklejanie do najbliższego paska | cały plik |
| `Manager.cs` | Singleton, `Awake()` dodaje użytkownika demo „Janusz”; `AddPlayer()` = pusty `TODO` | `Awake()` |
| `ASUPro/Scripts/ASUPro_Core.cs` | `DoLogin()` — login `Janusz`/`1234` wpisany na sztywno, reszta idzie do PHP | ok. linia 57 |

---

## Co powiedzieć, jeśli coś nie działa

| Problem | Reakcja |
|---------|---------|
| `.exe` się nie uruchamia | Sprawdź, czy skopiowano cały folder; alternatywnie Unity → Play |
| Edytor zadania się nie otwiera | Kliknij w dolną część karty (pod `title:`) |
| Drag & drop nie reaguje | Chwyć kartę za środek i przeciągnij **powoli** nad drugi pasek |
| Interfejs wygląda na ucięty | Używasz starej wersji v1.0 — pobierz v1.1 |
| Zapis nie działa | Kliknij dyskietkę jeszcze raz |
| Brak czasu | Pokaż nagranie backup |

---

## Czego NIE obiecywać na demo

- **Logowania** — kod istnieje (`ASUPro_Core.cs`), ale zbudowana aplikacja startuje od razu na tablicy zadań
- **Terminu zadania** — pole `endDate` jest w modelu (`TaskCell.cs`), ale w edytorze zadania nie ma pola daty
- **Dodawania członków zespołu** — jest tylko jeden użytkownik demo „Janusz” (`AddPlayer()` = `TODO`)
- **Rejestracji / logowania przez PHP** — skrypty PHP to gotowy pakiet ASUPro (nagłówek „CREATED BY JAKE”), używają API `mysql_*` usuniętego w PHP 7, `Config.php` jest pusty — backend nie jest podłączony
- **Zapisu zadań** — dane są tylko w pamięci
- `GetScores.cs` / `InsertScore.cs` — pozostałości tutoriala, nie część RP
- Modułów budżetowych, raportów, Gantta — **nie istnieją w kodzie**

---

## Szybka lista kontrolna — 5 min przed startem

```
[ ] ResearchPlanner.exe uruchomiony raz na próbę i zamknięty
[ ] Cursor / VS Code otwarty na ZarzProj/Assets
[ ] Backup wideo dostępny
[ ] Slajdy / PDF otwarte
[ ] Powiadomienia wyłączone
[ ] Laptop na zasilaniu
```

---

## Materiały do pokazania obok demo

| Plik | Kiedy pokazać |
|------|---------------|
| `KartaProjektu.md` | Wprowadzenie, zakres |
| `AnalizaWymagan.md` | Role interesariuszy, wymagania |
| `diagramy/aktor-opiekun.png` | Diagram UML — Opiekun |
| `image-6.png`, `image-7.png` | Diagramy UML — Kierownik / Lider |
| `Raport zamknięcia projektu.pdf` | Przebieg części II |
