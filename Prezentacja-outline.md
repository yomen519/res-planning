# Research Planner — outline prezentacji (~30 min)

> Materiał do obrony / prezentacji projektu.  
> Repo: `res-planning` | Demo: `ResearchPlanner.exe` (build Unity `ZarzProj`) — startuje bez logowania, patrz `Demo-checklist.md`

---

## Slajd 1 — Tytuł

**Research Planner (RP)**  
System zarządzania projektami badawczymi

- Wyższa Szkoła Administracji i Przedsiębiorczości w Lublinie
- Część I (analiza): Piotr Kotarski — kierownik, Jarosław Abramek — analityk, Michał Budzyński — programista
- Część II (prototyp, wg Raportu zamknięcia): Janusz Lejtan — kierownik, Jarosław Abramek — analityk, Artur Matuszewski — programista, Piotr Kotarski — dokumentalista
- Prowadzący: mgr Wojciech Moniuszko
- Data: 23 września 2026

---

## Slajd 2 — Problem biznesowy

**Dlaczego powstał projekt?**

- Zespoły badawcze korzystają z rozproszonych narzędzi (Excel, e-mail, komunikatory)
- Brak jednego miejsca na zadania, harmonogram, budżet i raporty
- Utrata przejrzystości, opóźnienia, trudności w rozliczeniach

**Cel:** jeden centralny system do planowania, realizacji i monitorowania projektów badawczych

---

## Slajd 3 — Zakres i korzyści

**Zakres (wg Karty projektu):**

- Planowanie zadań i harmonogramów
- Dashboard postępów i raportowanie
- Budżetowanie i rozliczenia
- Zarządzanie użytkownikami i rolami
- Bezpieczeństwo i zgodność z RODO

**Korzyści:**

- Lepsza koordynacja zespołu
- Większa przejrzystość i kontrola terminów
- Ułatwione rozliczanie kosztów

---

## Slajd 4 — Interesariusze systemu

**5 ról użytkowników** (źródło: `AnalizaWymagan.md`)

| Rola | Główne potrzeby |
|------|-----------------|
| Opiekun | Nadzór, akceptacja raportów i kamieni milowych |
| Kierownik projektu | Struktura prac, harmonogram, budżet |
| Lider zespołu | Delegowanie zadań, monitoring postępów |
| Członek zespołu | Realizacja zadań, raportowanie czasu |
| Księgowa | Faktury, płatności, zgodność finansowa |

---

## Slajd 5 — Wymagania funkcjonalne (wybrane)

**Kluczowe moduły:**

- Tworzenie i edycja projektów
- Zarządzanie zadaniami i kamieniami milowymi
- Harmonogram i monitoring terminów
- Moduł finansowy (budżet, faktury, rozliczenia)
- Raportowanie operacyjne i finansowe
- Komunikacja wewnętrzna i powiadomienia

**Wymagania niefunkcjonalne:**

- Czas reakcji < 1 s (Analiza wymagań; Karta projektu podawała ogólnie ≤ 3 s)
- Dostępność 99%
- Obsługa wielu projektów i użytkowników jednocześnie

---

## Slajd 6 — Model procesów (UML)

**Diagramy przypadków użycia**

- Opiekun → `diagramy/aktor-opiekun.png`
- Kierownik projektu → `image-6.png`
- Lider zespołu → `image-7.png`

**Przekaz na slajdzie:**

- Każda rola ma zdefiniowany zestaw przypadków użycia
- Model odzwierciedla rzeczywiste procesy w projektach badawczych
- Diagramy stanowią podstawę do dalszej implementacji

---

## Slajd 7 — Architektura docelowa vs prototyp

| Warstwa | Docelowo (dokumentacja) | Zaimplementowano (repo) |
|---------|-------------------------|-------------------------|
| Frontend | React, TypeScript, CSS3 | Unity 2022.3 (C#, uGUI) |
| Backend | Java, Spring Boot | Przykładowe skrypty PHP z pakietu ASUPro — niepodłączone |
| Baza | PostgreSQL | Schemat MySQL (`asupro.sql`) — tylko tabela użytkowników |
| Klient | Przeglądarka | Aplikacja desktop (Unity) |

**Komunikat:** prototyp UI potwierdza koncepcję; docelowa architektura webowa pozostaje w planie rozwoju

---

## Slajd 8 — Co zostało zaimplementowane

**Działający prototyp (Unity, uruchamiany jako `.exe`):**

- Panel zarządzania zadaniami (paski etapów + karty zadań)
- Edycja zadania: tytuł, treść, przypisana osoba
- Drag & drop — przenoszenie zadań między paskami
- Jeden użytkownik demo („Janusz”)

**Tylko w kodzie / niepodłączone:**

- Logowanie (`ASUPro_Core.cs`) — aplikacja startuje bez ekranu logowania
- Termin zadania — pole w modelu, brak w edytorze
- Skrypty PHP i schemat `asupro.sql` — przykładowy pakiet, API `mysql_*` usunięte w PHP 7

---

## Slajd 9 — LIVE DEMO (scenariusz)

**Kroki na żywo (~5 min) + kod (~3 min):**

1. Uruchomienie `ResearchPlanner.exe` — tablica „TASKbar ORGANIZER 5000”
2. **ADD TASK BAR** ×2 — dwa etapy
3. **NEW TASK** → klik w kartę → edytor zadania (krótki tytuł)
4. Przypisanie osoby: **+** → Janusz → zapis (dyskietka)
5. Przeciągnięcie zadania między paskami
6. Pokaz kodu źródłowego (`TaskBar.cs`, `TaskCell.cs`, `TaskConfigurator.cs`, `Dragme.cs`)

**Co pokazujemy:** koncepcję interfejsu do planowania pracy zespołu

---

## Slajd 10 — Kluczowe komponenty kodu

| Komponent | Plik | Odpowiedzialność |
|-----------|------|------------------|
| Manager | `Manager.cs` | Singleton, lista graczy, panele UI |
| TaskBar | `TaskBar.cs` | Pasek zadań, dodawanie zadań |
| TaskCell | `TaskCell.cs` | Model pojedynczego zadania |
| TaskConfigurator | `TaskConfigurator.cs` | Formularz edycji zadania |
| Dragme | `Dragme.cs` | Przeciąganie zadań między listami |
| ASUPro_Core | `ASUPro_Core.cs` | Logowanie z gotowego pakietu ASUPro (niewidoczne w demo) |

---

## Slajd 11 — Luki i dalszy rozwój

**Niezaimplementowane (poza prototypem UI):**

- Persystencja zadań i projektów (brak zapisu do bazy)
- Role i uprawnienia (5 interesariuszy)
- Harmonogram Gantta, kamienie milowe
- Moduł budżetowy i raportowy
- Dashboard KPI, powiadomienia, integracja e-mail

**Roadmapa:**

1. Rozszerzenie schematu bazy (projekty, zadania, role)
2. API REST (docelowo Spring Boot)
3. Frontend webowy (React)
4. Moduły finansowe i raportowe

---

## Slajd 12 — Podsumowanie

**Osiągnięcia projektu:**

- Pełna analiza wymagań i model UML
- Zdefiniowane role, procesy i zakres funkcjonalny
- Działający prototyp UI zarządzania zadaniami (`.exe`)
- Kod źródłowy z komentarzami w repozytorium GitHub

**Wnioski:**

Research Planner to solidna analiza biznesowa z proof-of-concept interfejsu.  
Kolejny etap to rozbudowa backendu i modułów biznesowych zgodnie z dokumentacją.

**Pytania?**

---

## Slajd opcjonalny — Harmonogram projektu

| Etap | Zakres | Status |
|------|--------|--------|
| 1–2 | Analiza wymagań | ✅ Ukończone |
| 3–4 | Projekt systemu (UML, architektura) | ✅ Ukończone |
| 5–9 | Implementacja backend + frontend | ⚠️ Prototyp |
| 10 | Testy | ❌ Brak |
| 11–12 | Dokumentacja i prezentacja | ✅ W toku |

---

## Slajd opcjonalny — Ryzyka projektu

| Ryzyko | Mitygacja |
|--------|-----------|
| Rozbieżność dokumentacja ↔ kod | Jawne przedstawienie jako POC + roadmapa |
| Brak persystencji danych | Zaplanowanie rozszerzenia bazy |
| Przestarzały backend PHP | Migracja do Spring Boot |
| Ograniczony zakres demo | Skupienie na analizie + prototyp UI |

---

## Wskazówki dla prowadzącego prezentację

- **Slajdy 1–7:** mów spokojnie, opieraj się na dokumentacji — to mocna strona
- **Slajd 9 (demo):** przećwicz wcześniej według `Demo-checklist.md` — nie zapowiadaj logowania ani terminu zadania
- **Slajd 11:** bądź uczciwy — lepiej pokazać świadomość luk niż udawać pełny produkt
- **Czas:** 30 min = ~22 min mowa + 8 min demo; zostaw 2–3 min na pytania
