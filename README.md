# Research Planner (RP)

System zarządzania projektami badawczymi — projekt zespołowy, Wyższa Szkoła Administracji i Przedsiębiorczości w Lublinie.  
Prowadzący: mgr Wojciech Moniuszko.

## Uruchomienie gotowej aplikacji (Windows)

Najszybciej — bez instalowania Unity:

1. Pobierz `ResearchPlanner-v1.1-win64.zip` z [Releases → v1.1-prezentacja](https://github.com/yomen519/res-planning/releases/tag/v1.1-prezentacja)
2. Rozpakuj całe archiwum i uruchom `ResearchPlanner\ResearchPlanner.exe`
3. Jeśli Windows pokaże ostrzeżenie SmartScreen (program nie jest podpisany): **Więcej informacji → Uruchom mimo to**

## Pobranie kodu źródłowego

Projekt Unity zawiera pliki o bardzo długich ścieżkach. Na Windows klonuj z włączoną obsługą długich ścieżek:

```bash
git clone -c core.longpaths=true https://github.com/yomen519/res-planning.git
```

Bez tej opcji `git clone` kończy się błędem `Filename too long`.

## Otwarcie projektu w Unity

- Edytor: **Unity 2022.3.62f3** (w Unity Hub: `Installs → Install Editor → Archive`)
- Unity Hub → `Add project from disk` → folder **`ZarzProj`**
- Scena: `Assets/Scenes/SampleScene.unity` → **Play ▶**

Nie otwieraj projektu w Unity 6 — Hub zaproponuje upgrade projektu.

## Zawartość repozytorium

| Ścieżka | Opis |
|---------|------|
| `KartaProjektu.md` | Karta projektu — cel, zakres, harmonogram, ryzyka |
| `AnalizaWymagan.md` | Interesariusze, wymagania, przypadki użycia |
| `diagramy/`, `image-5.png` … `image-7.png` | Diagramy przypadków użycia UML |
| `Raport zamknięcia projektu.pdf` | Raport zamknięcia części II |
| `ZarzProj/` | Kod źródłowy prototypu (Unity, C#) |
| `ZarzProj/Assets/Scripts/` | Główne klasy: `TaskCell`, `TaskConfigurator`, `Dragme` |
| `Prezentacja-*.md`, `Demo-checklist.md` | Materiały do prezentacji i scenariusz demo |

## Stan prototypu

Działa: paski etapów wraz z nadawaniem im nazw, tworzenie i edycja zadań, przypisanie osoby, przeciąganie zadań między etapami.  
Nie działa / niepodłączone: logowanie (kod w `ASUPro_Core.cs`), backend PHP, zapis danych — szczegóły w `Demo-checklist.md`.
