# Prezentacja 10 min — Jarosław Abramek, Analityk

> **Czas:** dokładnie ~10 minut (bez demo)  
> **Tempo:** spokojne, ale zwięzłe — ok. 120 słów/min

---

## CAŁY TEKST DO PRZECZYTANIA

Dzień dobry. Nazywam się **Jarosław Abramek**, jestem **analitykiem** projektu **Research Planner** — systemu do zarządzania projektami badawczymi.

Projekt miał **dwie części**. W pierwszej opracowaliśmy analizę wymagań, w drugiej zbudowano prototyp w Unity. Opowiem krótko o obu.

---

**Problem:** zespoły badawcze korzystają z rozproszonych narzędzi — Excel, e-mail, komunikatory. Brakuje jednego systemu na zadania, harmonogram, budżet i raporty. **Cel:** centralna aplikacja wspierająca planowanie i monitorowanie projektów.

---

**Część pierwsza** — październik 2025 do stycznia 2026. Moja rola: analiza wymagań i modelowanie procesów.

Zidentyfikowaliśmy **pięć ról**: Opiekun nadzoruje i akceptuje raporty, Kierownik planuje prace i budżet, Lider deleguje zadania, Członek zespołu je realizuje, Księgowa obsługuje finanse.

Opisaliśmy **ponad dwadzieścia wymagań funkcjonalnych** i **dziewięć niefunkcjonalnych** — m.in. RODO, szyfrowanie TLS, czas reakcji poniżej sekundy. Wszystko w dokumencie `AnalizaWymagan.md`.

Dla trzech ról opracowaliśmy **przypadki użycia i diagramy UML** — Opiekun, Kierownik projektu, Lider zespołu. **[Pokaż: `diagramy/aktor-opiekun.png`, `image-6.png`, `image-7.png`]** Dla Księgowej i Członka mamy wymagania, ale bez pełnych diagramów — to luka do uzupełnienia.

W **Karcie projektu** zapisaliśmy zakres, harmonogram i planowaną architekturę: React, Java, Spring Boot, PostgreSQL.

---

**Część druga** — marzec do czerwca 2026. Zespół zbudował **prototyp w Unity**.

Co działa: logowanie, paski zadań jako etapy projektu, tworzenie i edycja zadań, przypisanie osoby, przeciąganie zadań między etapami.

Czego brakuje: moduł finansowy, raportowanie, harmonogram Gantta, system ról, zapis zadań do bazy. Prototyp pokrywa głównie wymagania **Kierownika** i **Lidera** — reszta specyfikacji pozostała w dokumentacji.

Projekt zakończono przed wdrożeniem. W **Raporcie zamknięcia** wskazano przyczyny organizacyjne — problemy komunikacji i odejście części zespołu — nie techniczne.

---

**Podsumowując:** w części pierwszej dostarczyliśmy pełną analizę — interesariusze, wymagania, UML. W części drugiej powstał prototyp UI potwierdzający koncepcję zadań i delegowania. Pełny system opisany w dokumentacji czeka na kolejną iterację implementacji.

Dziękuję za uwagę. Chętnie odpowiem na pytania.

---

## PODZIAŁ CZASU

| Blok | Czas |
|------|------|
| Wstęp + problem | 1 min |
| Część I — role, wymagania, UML | 4 min |
| Część II — prototyp, luki, raport | 3,5 min |
| Podsumowanie + pytania | 1,5 min |
| **Razem** | **~10 min** |

---

## 3 SLAJDY — MINIMUM

**Slajd 1 — Część I**
- Problem: rozproszone narzędzia → cel: jeden system
- 5 ról interesariuszy
- Analiza wymagań + 3 diagramy UML

**Slajd 2 — Część II**
- Prototyp Unity: zadania, login, drag & drop
- Brak: budżet, raporty, role, zapis do bazy
- Raport zamknięcia: przyczyny organizacyjne

**Slajd 3 — Podsumowanie**
- Część I: pełna analiza ✅
- Część II: POC interfejsu ⚠️
- Następny krok: implementacja według specyfikacji

---

## ŚCIĄGAWKA (kartka A6)

```
JA: Jarosław Abramek — analityk

I (2025–2026): 5 ról, 20+ RF, UML ×3, Karta projektu
II (2026): Unity — zadania, login, drag | brak: finanse, raporty
Status: analiza ✅ | prototyp ⚠️ | wdrożenie ❌

Diagramy: aktor-opiekun, image-6, image-7
```
