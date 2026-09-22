# Research Planner — outline prezentacji (~30 min)

> Materiał do obrony / prezentacji projektu.  
> Repo: `res-planning` | Demo: Unity `ZarzProj` | Login demo: `Janusz` / `1234`

---

## Slajd 1 — Tytuł

**Research Planner (RP)**  
System zarządzania projektami badawczymi

- Wyższa Szkoła Administracji i Przedsiębiorczości w Lublinie
- Zespół: Piotr Kotarski, Jarosław Abramek, Michał Budzyński
- Prowadzący: mgr Wojciech Moniuszko
- Data: październik 2025

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

- Czas odpowiedzi ≤ 3 s
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
| Backend | Java, Spring Boot | PHP (`Login.php`, `Register.php`) |
| Baza | PostgreSQL | MySQL — tabela użytkowników |
| Klient | Przeglądarka | Aplikacja desktop (Unity) |

**Komunikat:** prototyp UI potwierdza koncepcję; docelowa architektura webowa pozostaje w planie rozwoju

---

## Slajd 8 — Co zostało zaimplementowane

**Działający prototyp (Unity):**

- Ekran logowania i rejestracji
- Panel zarządzania zadaniami (paski + lista zadań)
- Edycja zadania: nazwa, opis, termin, przypisana osoba
- Drag & drop — przenoszenie zadań między paskami
- Lista członków zespołu (demo)

**Backend:**

- Logowanie i rejestracja użytkownika (PHP + MySQL)
- Schemat bazy: `asupro.sql`

---

## Slajd 9 — LIVE DEMO (scenariusz)

**Kroki na żywo (~8 min):**

1. Uruchomienie `SampleScene.unity` w Unity
2. Logowanie: `Janusz` / `1234`
3. Widok członków zespołu
4. Dodanie nowego paska zadań
5. Dodanie i edycja zadania w konfiguratorze
6. Przypisanie osoby do zadania
7. Przeciągnięcie zadania między paskami

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
| ASUPro_Core | `ASUPro_Core.cs` | Logowanie, komunikacja z PHP |

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
- Działający prototyp UI zarządzania zadaniami
- Podstawa backendu (autentykacja użytkowników)

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
- **Slajd 9 (demo):** przećwicz wcześniej według `Demo-checklist.md`
- **Slajd 11:** bądź uczciwy — lepiej pokazać świadomość luk niż udawać pełny produkt
- **Czas:** 30 min = ~22 min mowa + 8 min demo; zostaw 2–3 min na pytania
