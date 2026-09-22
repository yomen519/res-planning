# Research Planner — slajdy do skopiowania (PowerPoint / Google Slides)

> **Jak używać:** Skopiuj treść każdego slajdu do osobnego slajdu w PowerPoint lub Google Slides.  
> **Szablon:** Ciemny nagłówek + jasne tło, font: Calibri / Arial, rozmiar tytułu 32–36 pt, treść 18–22 pt.  
> **Czas całości:** ~30 min (22 min mowa + 8 min demo)

---

## SLIDE 1 — Tytuł

### Tytuł slajdu
```
Research Planner (RP)
System zarządzania projektami badawczymi
```

### Treść slajdu
```
Wyższa Szkoła Administracji i Przedsiębiorczości w Lublinie

Część I — analiza (paź 2025 – sty 2026):
• Piotr Kotarski — Kierownik projektu
• Jarosław Abramek — Analityk
• Michał Budzyński — Programista

Część II — prototyp (mar – cze 2026):
• Janusz Lejtan — Kierownik zespołu
• Jarosław Abramek — Analityk
• Artur Matuszewski — Programista
• Piotr Kotarski — Dokumentalista

Prowadzący: mgr Wojciech Moniuszko
23 września 2026
```

### Układ
- Tło: jednolite (np. granat #1a365d lub białe z logo uczelni)
- Logo WSAP — lewy górny róg (jeśli dostępne)
- Tytuł wyśrodkowany

### Notatka dla prowadzącego
Slajd tytułowy — powiedz krótkie powitanie, przedstaw zespół i temat.

---

## SLIDE 2 — Problem biznesowy

### Tytuł slajdu
```
Dlaczego powstał Research Planner?
```

### Treść slajdu
```
Problem:
• Zespoły badawcze korzystają z rozproszonych narzędzi
  (Excel, e-mail, komunikatory, notatki)
• Brak jednego miejsca na zadania, harmonogram, budżet i raporty
• Utrata przejrzystości, opóźnienia, trudności w rozliczeniach

Cel projektu:
→ Jeden centralny system do planowania, realizacji
  i monitorowania projektów badawczych
```

### Układ
- Lewa kolumna: „Problem” (ikona ⚠ lub czerwony akcent)
- Prawa kolumna lub dolna część: „Cel” (ikona ✓ lub zielony akcent)

### Grafika (opcjonalnie)
- Schemat: wiele narzędzi → jeden system (strzałka w prawo)

---

## SLIDE 3 — Zakres i korzyści

### Tytuł slajdu
```
Zakres projektu i korzyści
```

### Treść slajdu
```
W zakresie projektu:
• Planowanie zadań i harmonogramów
• Dashboard postępów i raportowanie
• Budżetowanie i rozliczenia
• Zarządzanie użytkownikami, rolami i uprawnieniami
• Bezpieczeństwo i zgodność z RODO

Korzyści:
• Lepsza koordynacja pracy zespołu
• Większa przejrzystość i kontrola terminów
• Ułatwione rozliczanie kosztów projektu
```

### Układ
- Dwie kolumny: Zakres | Korzyści
- Można dodać ikony przy każdym punkcie

---

## SLIDE 4 — Interesariusze

### Tytuł slajdu
```
Interesariusze systemu — 5 ról użytkowników
```

### Treść slajdu (tabela)
```
┌─────────────────────┬──────────────────────────────────────────────┐
│ Rola                │ Główne potrzeby                              │
├─────────────────────┼──────────────────────────────────────────────┤
│ Opiekun             │ Nadzór, akceptacja raportów i kamieni        │
│                     │ milowych                                     │
├─────────────────────┼──────────────────────────────────────────────┤
│ Kierownik projektu  │ Struktura prac, harmonogram, budżet          │
├─────────────────────┼──────────────────────────────────────────────┤
│ Lider zespołu       │ Delegowanie zadań, monitoring postępów       │
├─────────────────────┼──────────────────────────────────────────────┤
│ Członek zespołu     │ Realizacja zadań, raportowanie czasu pracy   │
├─────────────────────┼──────────────────────────────────────────────┤
│ Księgowa            │ Faktury, płatności, zgodność finansowa       │
└─────────────────────┴──────────────────────────────────────────────┘
```

### Układ
- Tabela na całym slajdzie
- Alternatywnie: 5 „kart” z ikonami postaci w rzędzie

### Źródło (małym drukiem na dole)
```
Źródło: AnalizaWymagan.md
```

---

## SLIDE 5 — Wymagania funkcjonalne

### Tytuł slajdu
```
Wymagania funkcjonalne i niefunkcjonalne
```

### Treść slajdu
```
Moduły funkcjonalne:
• Tworzenie i edycja projektów
• Zarządzanie zadaniami i kamieniami milowymi
• Harmonogram i monitoring terminów
• Moduł finansowy (budżet, faktury, rozliczenia)
• Raportowanie operacyjne i finansowe
• Komunikacja wewnętrzna i powiadomienia

Wymagania niefunkcjonalne:
• Czas reakcji systemu poniżej 1 sekundy
• Dostępność usługi: 99%
• Obsługa wielu projektów i użytkowników jednocześnie
```

### Układ
- Górna połowa: moduły (lista z ikonami)
- Dolna połowa: wymagania niefunkcjonalne (w ramce / box)

---

## SLIDE 6 — Diagramy UML

### Tytuł slajdu
```
Model procesów — diagramy przypadków użycia (UML)
```

### Treść slajdu
```
Dla każdej roli opracowano diagram przypadków użycia:

• Opiekun — nadzór nad projektem, akceptacja raportów
• Kierownik projektu — planowanie, budżet, harmonogram
• Lider zespołu — delegowanie i monitoring zadań

Diagramy stanowią podstawę do implementacji modułów systemu.
```

### Grafika do wstawienia
```
Wstaw obraz: diagramy/aktor-opiekun.png
(opcjonalnie obok: image-6.png, image-7.png jako miniatury)
```

### Układ
- Duży diagram Opiekuna na środku lub po lewej
- Krótki opis po prawej

---

## SLIDE 7 — Architektura

### Tytuł slajdu
```
Architektura docelowa vs zaimplementowany prototyp
```

### Treść slajdu (tabela)
```
┌──────────┬─────────────────────────┬─────────────────────────────┐
│ Warstwa  │ Docelowo (dokumentacja) │ Zaimplementowano (prototyp) │
├──────────┼─────────────────────────┼─────────────────────────────┤
│ Frontend │ React, TypeScript       │ Unity 2022.3 (C#, uGUI)     │
│ Backend  │ Java, Spring Boot       │ PHP — przykład, niepodłącz. │
│ Baza     │ PostgreSQL              │ Schemat MySQL (użytkownicy) │
│ Klient   │ Przeglądarka www        │ Aplikacja desktop (Unity)   │
└──────────┴─────────────────────────┴─────────────────────────────┘

Prototyp UI potwierdza koncepcję systemu.
Docelowa architektura webowa pozostaje w planie rozwoju.
```

### Układ
- Tabela z kolorowym nagłówkiem
- Pod tabelą — jedno zdanie podsumowujące (pogrubione)

---

## SLIDE 8 — Zaimplementowane funkcje

### Tytuł slajdu
```
Co zostało zaimplementowane?
```

### Treść slajdu
```
Działa (aplikacja .exe):
✓ Paski etapów projektu
✓ Tworzenie i edycja zadań: tytuł, treść
✓ Przypisanie osoby do zadania
✓ Drag & drop — przenoszenie zadań między paskami

Tylko w kodzie / niepodłączone:
⚠ Logowanie (ASUPro_Core) — aplikacja startuje bez niego
⚠ Termin zadania — pole w modelu, brak w edytorze
⚠ Skrypty PHP + schemat MySQL — przykładowy pakiet
```

### Układ
- Dwie kolumny z checkmarkami
- Opcjonalnie: zrzut ekranu z Unity (jeśli masz)

---

## SLIDE 9 — LIVE DEMO

### Tytuł slajdu
```
Demonstracja na żywo — prototyp interfejsu
```

### Treść slajdu
```
Scenariusz demo (~5 min) + kod (~3 min):

1. Uruchomienie aplikacji (ResearchPlanner.exe)
2. Dodanie etapów (ADD TASK BAR)
3. Utworzenie i edycja zadania (NEW TASK)
4. Przypisanie osoby do zadania
5. Przeniesienie zadania między etapami (drag & drop)
6. Kod źródłowy — kluczowe klasy C#

→ Przechodzimy do demonstracji na żywo
```

### Układ
- Lista numerowana, duża czcionka
- Tło może być ciemniejsze — sygnał przejścia do demo
- **Po tym slajdzie: uruchom ResearchPlanner.exe, nie czytaj dalej slajdów**

---

## SLIDE 10 — Komponenty kodu

### Tytuł slajdu
```
Architektura kodu — kluczowe komponenty
```

### Treść slajdu (tabela)
```
┌──────────────────┬─────────────────────┬────────────────────────────┐
│ Komponent        │ Plik                │ Odpowiedzialność           │
├──────────────────┼─────────────────────┼────────────────────────────┤
│ Manager          │ Manager.cs          │ Singleton, lista członków  │
│ TaskBar          │ TaskBar.cs          │ Pasek zadań                │
│ TaskCell         │ TaskCell.cs         │ Model pojedynczego zadania │
│ TaskConfigurator │ TaskConfigurator.cs │ Formularz edycji zadania   │
│ Dragme           │ Dragme.cs           │ Przeciąganie zadań         │
│ ASUPro_Core      │ ASUPro_Core.cs      │ Logowanie (gotowy pakiet)  │
└──────────────────┴─────────────────────┴────────────────────────────┘
```

### Układ
- Tabela na całym slajdzie
- Opcjonalnie: fragment kodu `TaskCell.cs` (5–10 linii) jako obrazek

---

## SLIDE 11 — Luki i rozwój

### Tytuł slajdu
```
Luki implementacyjne i dalszy rozwój
```

### Treść slajdu
```
Niezaimplementowane w prototypie:
• Działające logowanie i backend
• Persystencja zadań i projektów (brak zapisu do bazy)
• Role i uprawnienia (5 interesariuszy)
• Harmonogram Gantta, kamienie milowe
• Moduł budżetowy i raportowy
• Dashboard KPI, powiadomienia, e-mail

Planowana roadmapa:
1. Rozszerzenie schematu bazy (projekty, zadania, role)
2. API REST (docelowo Spring Boot)
3. Frontend webowy (React + TypeScript)
4. Moduły finansowe i raportowe
```

### Układ
- Lewa kolumna: luki (szary / pomarańczowy akcent)
- Prawa kolumna: roadmapa (numerowana lista, zielony akcent)

---

## SLIDE 12 — Podsumowanie

### Tytuł slajdu
```
Podsumowanie
```

### Treść slajdu
```
Osiągnięcia projektu:
• Pełna analiza wymagań i model UML
• Zdefiniowane role, procesy i zakres funkcjonalny
• Działający prototyp UI zarządzania zadaniami (.exe)
• Kod źródłowy z komentarzami w repozytorium GitHub

Wnioski:
Research Planner to solidna analiza biznesowa
z proof-of-concept interfejsu użytkownika.
Kolejny etap: rozbudowa backendu i modułów biznesowych.

Dziękujemy za uwagę. Pytania?
```

### Układ
- Wyśrodkowany tekst
- Duży napis „Pytania?” na dole

---

## SLIDE 13 (opcjonalny) — Harmonogram

### Tytuł slajdu
```
Harmonogram realizacji projektu
```

### Treść slajdu (tabela)
```
┌─────────┬────────────────────────────────────┬──────────────┐
│ Etap    │ Zakres                             │ Status       │
├─────────┼────────────────────────────────────┼──────────────┤
│ 1–2     │ Analiza wymagań                    │ ✓ Ukończone  │
│ 3–4     │ Projekt systemu (UML, architektura)│ ✓ Ukończone  │
│ 5–9     │ Implementacja backend + frontend │ ⚠ Prototyp   │
│ 10      │ Testy                              │ ✗ Brak       │
│ 11–12   │ Dokumentacja i prezentacja         │ ✓ W toku     │
└─────────┴────────────────────────────────────┴──────────────┘
```

---

## SLIDE 14 (opcjonalny) — Ryzyka

### Tytuł slajdu
```
Ryzyka projektu i sposoby mitygacji
```

### Treść slajdu (tabela)
```
┌──────────────────────────────┬─────────────────────────────────────┐
│ Ryzyko                       │ Mitygacja                           │
├──────────────────────────────┼─────────────────────────────────────┤
│ Rozbieżność dokumentacja↔kod │ Jawne przedstawienie jako POC       │
│ Brak persystencji danych     │ Plan rozszerzenia bazy danych       │
│ Przestarzały backend PHP     │ Migracja do Spring Boot             │
│ Ograniczony zakres demo      │ Skupienie na analizie + prototyp UI │
└──────────────────────────────┴─────────────────────────────────────┘
```

---

## Szybka instrukcja — PowerPoint

1. Otwórz PowerPoint → Nowa prezentacja → wybierz szablon (np. „Ion” lub „Facet”)
2. Dla każdego slajdu powyżej: **Nowy slajd → Tytuł i treść**
3. Wklej tytuł i treść z tego pliku
4. Slajd 6: **Wstaw → Obrazy** → `diagramy/aktor-opiekun.png`
5. Slajd 8: opcjonalnie zrzut ekranu Unity
6. Slajd 9: ustaw ciemne tło — sygnał przejścia do demo
7. Eksportuj PDF jako backup

## Szybka instrukcja — Google Slides

1. slides.google.com → Pusta prezentacja
2. Skopiuj slajdy jak wyżej
3. **Plik → Importuj slajdy** nie jest potrzebny — ręczne kopiowanie wystarczy
4. Udostępnij link zespołowi do wspólnej edycji

## Lista plików graficznych do wstawienia

| Slajd | Plik | Ścieżka |
|-------|------|---------|
| 6 | Diagram Opiekun | `diagramy/aktor-opiekun.png` |
| 6 (opcja) | Diagram Kierownik | `image-6.png` |
| 6 (opcja) | Diagram Lider | `image-7.png` |
| 8 (opcja) | Zrzut Unity | zrób sam przed prezentacją |
