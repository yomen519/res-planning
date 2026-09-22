# Prezentacja skrócona (~20 min) — Jarosław Abramek, Analityk

> **Czas:** ok. 20 minut (bez demo) lub ~25 minut (z demo 5 min)  
> **Rola:** Analityk — obie części projektu w skrócie

---

## WSTĘP (1 min)

Dzień dobry. Nazywam się **Jarosław Abramek**, jestem **analitykiem** w projekcie **Research Planner** — systemu zarządzania projektami badawczymi.

Projekt miał **dwie części**: pierwsza to analiza i dokumentacja, druga to prototyp w Unity. Opowiem krótko o obu.

---

## CZĘŚĆ I — ANALIZA (8 min)

### Problem i cel

Zespoły badawcze pracują w rozproszony sposób — Excel, e-mail, komunikatory. Brakuje jednego miejsca na zadania, harmonogram, budżet i raporty.

**Cel:** centralny system do planowania, realizacji i monitorowania projektów badawczych.

### Pięć ról użytkowników

| Rola | Główna odpowiedzialność |
|------|-------------------------|
| Opiekun | Nadzór, akceptacja raportów |
| Kierownik projektu | Struktura prac, harmonogram, budżet |
| Lider zespołu | Zespoły, delegowanie zadań |
| Członek zespołu | Realizacja zadań, raportowanie |
| Księgowa | Budżet, faktury, rozliczenia |

### Wymagania — w skrócie

Zdefiniowaliśmy **ponad 20 wymagań funkcjonalnych** i **9 niefunkcjonalnych** — m.in. czas reakcji poniżej 1 sekundy, RODO, TLS, WCAG, skalowalność.

Wszystko w pliku `AnalizaWymagan.md`.

### Przypadki użycia i UML

Dla **trzech ról** opracowaliśmy szczegółowe scenariusze i diagramy:

- **Opiekun** → `diagramy/aktor-opiekun.png`
- **Kierownik projektu** → `image-6.png`
- **Lider zespołu** → `image-7.png`

Każdy przypadek ma scenariusz główny i alternatywne — np. brak uprawnień, brak danych.

**Luka:** dla Księgowej i Członka zespołu mamy wymagania, ale bez pełnych scenariuszy UML.

### Karta projektu

Planowana architektura: **React + TypeScript**, **Java + Spring Boot**, **PostgreSQL**. Harmonogram 11 tygodni. Kryteria sukcesu i ryzyka — w `KartaProjektu.md`.

**Część I zakończona** — mamy kompletną specyfikację biznesową.

---

## CZĘŚĆ II — PROTOTYP (6 min)

### Co powstało

W marcu 2026 ruszyła implementacja w **Unity**. Skład zespołu się zmienił (wg Raportu zamknięcia: Janusz Lejtan — kierownik, Artur Matuszewski — programista, Piotr Kotarski — dokumentalista), ja zostałem analitykiem.

**Zaimplementowano (prototyp UI):**
- paski zadań = etapy projektu,
- tworzenie i edycja zadań (tytuł, treść),
- przypisanie osoby do zadania,
- drag & drop między etapami.

**Nie zaimplementowano:**
- logowanie w działającej aplikacji (kod jest, ale aplikacja startuje bez niego), backend PHP niepodłączony,
- pole terminu w edytorze (termin jest tylko w modelu danych),
- moduł finansowy, raportowanie, Gantt,
- role i uprawnienia (5 interesariuszy),
- zapis zadań do bazy,
- moduły Opiekuna i Księgowej.

### Mapowanie: analiza → kod

| Wymaganie | Prototyp |
|-----------|----------|
| Zarządzanie zadaniami | ✅ |
| Delegowanie zadań | ✅ |
| Planowanie czasowe (termin) | ⚠️ tylko w modelu |
| Formowanie zespołów | ⚠️ demo |
| Budżet, raporty, nadzór | ❌ |

Prototyp pokrywa wąski fragment specyfikacji — głównie obszar Kierownika i Lidera.

### Problemy drugiej fazy

Projekt zakończony przed wdrożeniem. Przyczyny: **problemy komunikacyjne**, odejście części zespołu, opóźnienia. Opisane w `Raport zamknięcia projektu.pdf`. Główna przyczyna — organizacyjna, nie techniczna.

---

## DEMO (5 min) + KOD (3 min)

**[Uruchom `ResearchPlanner.exe` — aplikacja startuje od razu na tablicy zadań]**

1. **ADD TASK BAR** ×2 — dwa etapy
2. **NEW TASK** → kliknij kartę → tytuł „Analiza”
3. **+** przy „Assign Person” → **Janusz** → X → czerwona dyskietka (zapis)
4. Przeciągnij kartę na drugi pasek

*„To realizacja wymagań Kierownika — struktura prac — i Lidera — delegowanie zadań. Reszta specyfikacji czeka na implementację.”*

**[Zamknij aplikację → pokaż kod: `TaskBar.cs`, `TaskCell.cs`, `TaskConfigurator.cs`, `Dragme.cs`]**

---

## PODSUMOWANIE (2 min)

**Część I — osiągnięcia:**
- 5 interesariuszy, pełna analiza wymagań,
- 3 diagramy UML, przypadki użycia,
- Karta projektu z zakresem i architekturą docelową.

**Część II — osiągnięcia:**
- działający prototyp UI zadań (uruchamiany jako `.exe`),
- potwierdzenie koncepcji pasków i delegowania,
- raport zamknięcia z wnioskami.

**Wnioski:** Mamy solidną analizę i POC interfejsu. Pełny system — do zbudowania w kolejnej iteracji według naszej specyfikacji.

Dziękuję. Pytania?

---

## Ściągawka — 1 strona

```
CZĘŚĆ I (paź 2025 – sty 2026)
• 5 ról, 20+ RF, 9 RNF
• UML: Opiekun, Kierownik, Lider
• Plan: React + Java + PostgreSQL

CZĘŚĆ II (mar – cze 2026)
• Unity: etapy, zadania, delegowanie, drag & drop
• Brak: login (tylko w kodzie), backend, zapis DB, budżet, raporty, role
• Status: prototyp, nie wdrożony

DEMO: .exe → ADD TASK BAR → NEW TASK → Janusz → drag → kod

JA (analityk): wymagania, UML, mapowanie na kod
```
