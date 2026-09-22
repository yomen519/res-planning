# Research Planner — skrypt wypowiedzi do prezentacji

> **Czas całości:** ~30 minut  
> **Struktura:** 22 min mowa + 8 min demo na żywo + 2–3 min pytania  
> **Wskazówka:** Mów naturalnie — tekst poniżej to propozycja, nie musisz czytać słowo w słowo.

---

## SLIDE 1 — Tytuł (~1 min)

**[Patrz na publiczność, uśmiech]**

Dzień dobry. Nazywam się [imię] i wraz z zespołem — Jarosławem Abramkiem oraz Michałem Budzyńskim — przedstawiamy projekt **Research Planner**, czyli system zarządzania projektami badawczymi.

Projekt realizowaliśmy na Wyższej Szkole Administracji i Przedsiębiorczości w Lublinie pod opieką mgr Wojciecha Moniuszko. Ja pełniłem rolę kierownika projektu, Jarosław — analityka, a Michał — programisty.

Przejdźmy do tego, dlaczego w ogóle powstał taki system.

---

## SLIDE 2 — Problem biznesowy (~2 min)

Zespoły badawcze — zarówno na uczelniach, jak i w instytutach — często pracują w rozproszony sposób. Zadania zapisują w Excelu, komunikują się mailem lub na komunikatorach, a raporty składają w osobnych dokumentach.

To prowadzi do trzech głównych problemów:

Po pierwsze — **brak przejrzystości**. Nikt nie ma pełnego obrazu, co się dzieje w projekcie.

Po drugie — **opóźnienia**. Terminy giną w wiadomościach i notatkach.

Po trzecie — **trudności w rozliczeniach**. Budżet projektu jest rozproszony między różne pliki i systemy.

Dlatego postawiliśmy sobie cel: stworzyć **jeden centralny system**, który połączy planowanie, realizację i monitorowanie projektów badawczych w jednym miejscu.

---

## SLIDE 3 — Zakres i korzyści (~2,5 min)

Zakres naszego projektu obejmuje pięć głównych obszarów.

Po pierwsze — **planowanie zadań i harmonogramów**, czyli możliwość definiowania prac i terminów.

Po drugie — **dashboard postępów i raportowanie** — wizualizacja statusu projektu.

Po trzecie — **budżetowanie i rozliczenia** — kontrola kosztów i faktur.

Po czwarte — **zarządzanie użytkownikami i rolami** — każda osoba widzi tylko to, do czego ma uprawnienia.

I po piąte — **bezpieczeństwo i zgodność z RODO** — ochrona danych osobowych.

Jakie korzyści to daje? Lepszą koordynację zespołu, większą przejrzystość działań i ułatwione rozliczanie kosztów projektu.

---

## SLIDE 4 — Interesariusze (~3 min)

W analizie wymagań zidentyfikowaliśmy **pięć ról użytkowników** — interesariuszy systemu.

**Opiekun** — to osoba nadzorująca projekt z perspektywy strategicznej. Potrzebuje podglądu wyników i możliwości akceptacji raportów oraz kamieni milowych.

**Kierownik projektu** — planuje strukturę prac, harmonogram i budżet. To główny użytkownik modułu planowania.

**Lider zespołu** — deleguje zadania członkom i monitoruje ich postępy na co dzień.

**Członek zespołu** — realizuje przypisane zadania i raportuje czas pracy.

**Księgowa** — zajmuje się stroną finansową: faktury, płatności i zgodność z przepisami.

Każda z tych ról ma inny zestaw uprawnień i inne potrzeby — to kluczowe przy projektowaniu systemu.

---

## SLIDE 5 — Wymagania funkcjonalne (~3 min)

Na podstawie analizy interesariuszy zdefiniowaliśmy wymagania funkcjonalne i niefunkcjonalne.

**Moduły funkcjonalne** obejmują:

- tworzenie i edycję projektów,
- zarządzanie zadaniami i kamieniami milowymi,
- harmonogram z monitoringiem terminów,
- moduł finansowy — budżet, faktury, rozliczenia,
- raportowanie operacyjne i finansowe,
- oraz komunikację wewnętrzną z powiadomieniami.

**Wymagania niefunkcjonalne** to m.in.:

- czas odpowiedzi systemu nie dłuższy niż 3 sekundy,
- dostępność na poziomie 99 procent,
- oraz możliwość obsługi wielu projektów i użytkowników jednocześnie.

Te wymagania zostały szczegółowo opisane w dokumencie `AnalizaWymagan.md` dostępnym w repozytorium projektu.

---

## SLIDE 6 — Diagramy UML (~3 min)

**[Pokaż diagram na slajdzie]**

Dla każdej roli opracowaliśmy **diagram przypadków użycia** w notacji UML.

Na slajdzie widzicie diagram dla roli **Opiekuna**. Widać tu przypadki użycia takie jak: nadzór nad projektem, podgląd wyników, monitoring harmonogramów oraz akceptacja kamieni milowych i raportów.

Analogiczne diagramy przygotowaliśmy dla **Kierownika projektu** i **Lidera zespołu** — pliki `image-6.png` i `image-7.png` w repozytorium.

Te diagramy nie są tylko dokumentacją — stanowią **bezpośrednią podstawę** do projektowania modułów systemu i planowania implementacji.

---

## SLIDE 7 — Architektura (~2,5 min)

Tutaj warto być uczciwym wobec prowadzącego i publiczności.

W **dokumentacji projektowej** — w Karcie projektu — opisaliśmy docelową architekturę: frontend w **React i TypeScript**, backend w **Java i Spring Boot**, baza **PostgreSQL**, dostęp przez przeglądarkę.

W **zaimplementowanym prototypie** poszliśmy inną ścieżką technologiczną:

- klient to aplikacja **Unity** w C#,
- backend to skrypty **PHP** z bazą **MySQL**,
- a klient działa jako aplikacja desktopowa.

Dlaczego? Unity pozwoliło nam szybko zbudować **interaktywny prototyp interfejsu** — drag and drop, panele, formularze — bez pisania całego frontendu od zera.

Prototyp **potwierdza koncepcję** systemu. Docelowa architektura webowa pozostaje w planie dalszego rozwoju.

---

## SLIDE 8 — Zaimplementowane funkcje (~2 min)

Co konkretnie udało się zaimplementować?

Po stronie **klienta Unity** mamy:

- ekran logowania i rejestracji,
- panel zarządzania zadaniami z paskami i listami,
- edycję zadania — nazwa, opis, termin, przypisana osoba,
- mechanizm **drag and drop** — przenoszenie zadań między paskami,
- oraz listę członków zespołu.

Po stronie **backendu** — skrypty PHP obsługujące logowanie i rejestrację użytkownika oraz schemat bazy danych w pliku `asupro.sql`.

To nie jest jeszcze pełny system opisany w wymaganiach — to **działający proof-of-concept** interfejsu użytkownika.

Za chwilę pokażemy to na żywo.

---

## SLIDE 9 — Przejście do DEMO (~30 s)

**[Przełącz na Unity — nie czytaj długo]**

Przechodzimy teraz do **demonstracji na żywo**. Pokażemy prototyp interfejsu — logowanie, tworzenie zadań, przypisywanie osób i przenoszenie zadań między etapami projektu.

Scenariusz zajmie około 8 minut.

**[Kliknij Play w Unity]**

---

## DEMO NA ŻYWO — pełny skrypt (~8 min)

### Krok 1 — Uruchomienie (30 s)

Uruchamiamy prototyp interfejsu Research Planner w silniku Unity. To ta sama scena, nad którą pracowaliśmy podczas implementacji — `SampleScene`.

### Krok 2 — Logowanie (1 min)

Na ekranie widzimy panel logowania. Wpisuję dane testowe: login **Janusz**, hasło **1234**.

System weryfikuje użytkownika i przenosi nas do głównego panelu aplikacji.

W pełnej wersji systemu logowanie odbywa się przez backend PHP z bazą MySQL. W prototypie mamy też tryb demonstracyjny, który działa bez serwera — to ułatwia prezentację.

### Krok 3 — Członkowie zespołu (1 min)

Po zalogowaniu widzimy listę członków zespołu. W prototypie mamy domyślnego użytkownika Janusz — odpowiada to roli **Członek zespołu** z naszej analizy wymagań.

Każdy członek może być przypisany do konkretnych zadań w projekcie.

### Krok 4 — Dodanie paska zadań (1 min)

Klikam przycisk dodawania nowego paska zadań.

Pasek pojawia się z losowym kolorem — to wizualna organizacja etapów lub kategorii prac w projekcie. Na przykład: „Etap 1 — Przegląd literatury”, „Etap 2 — Badania terenowe” i tak dalej.

### Krok 5 — Dodanie i edycja zadania (1,5 min)

Na nowym pasku dodaję zadanie. Klikam na nie, aby otworzyć **konfigurator**.

Wypełniam przykładowe dane:
- **Nazwa:** „Przegląd literatury”
- **Opis:** „Analiza publikacji z ostatnich 5 lat na temat zarządzania projektami”
- **Termin:** 15 marca 2026

Zapisuję zmiany. Zadanie pojawia się na pasku z przypisanym terminem.

To odpowiada wymaganiu **Kierownika projektu** — definiowanie struktury prac z harmonogramem.

### Krok 6 — Przypisanie osoby (1 min)

W konfiguratorze przypisuję użytkownika Janusz do tego zadania.

Jego nazwa pojawia się na karcie zadania. To realizacja wymagania **Lidera zespołu** — delegowanie zadań konkretnym osobom.

### Krok 7 — Drag & drop (1,5 min)

Dodaję drugi pasek zadań — np. „Etap 2 — Analiza danych”.

Teraz **przeciągam** zadanie „Przegląd literatury” z pierwszego paska do drugiego.

To pokazuje elastyczność interfejsu — zadania można reorganizować między etapami projektu, np. gdy zmieniają się priorytety.

**[Kliknij Stop w Unity]**

To była demonstracja prototypu. Wracamy do slajdów.

---

## SLIDE 10 — Komponenty kodu (~2 min)

Kilka słów o architekturze kodu.

Aplikacja opiera się na kilku kluczowych komponentach w C#:

- **Manager** — singleton zarządzający listą członków zespołu i przełączaniem paneli UI.
- **TaskBar** — reprezentuje pasek zadań, odpowiednik etapu projektu.
- **TaskCell** — model pojedynczego zadania z nazwą, opisem, terminem i przypisaną osobą.
- **TaskConfigurator** — formularz edycji zadania, który właśnie widzieliście w demo.
- **Dragme** — obsługuje przeciąganie zadań między listami.
- **ASUPro_Core** — komunikacja z backendem PHP przy logowaniu i rejestracji.

Kod jest dostępny w repozytorium GitHub — `github.com/yomen519/res-planning`.

---

## SLIDE 11 — Luki i rozwój (~2,5 min)

Będziemy szczerzy co do tego, czego **jeszcze nie zaimplementowaliśmy**.

W prototypie brakuje:

- **zapisu danych** — zadania istnieją tylko w pamięci, po restarcie znikają,
- **systemu ról** — pięć interesariuszy jest w dokumentacji, ale nie w kodzie,
- **harmonogramu Gantta** i kamieni milowych,
- **modułu budżetowego** i raportowego,
- oraz **dashboardu KPI**, powiadomień i integracji z e-mailem.

**Planowany rozwój** — roadmapa — wygląda tak:

1. Rozszerzenie schematu bazy o tabele projektów, zadań i ról.
2. Budowa API REST — docelowo w Spring Boot.
3. Frontend webowy w React i TypeScript.
4. Moduły finansowe i raportowe zgodnie z analizą wymagań.

Świadomość tych luk i plan ich uzupełnienia to część dojrzałości projektowej — nie udajemy, że prototyp to gotowy produkt.

---

## SLIDE 12 — Podsumowanie (~2 min)

Podsumowując — co udało się osiągnąć w projekcie Research Planner?

Po pierwsze — **pełna analiza wymagań** z pięcioma rolami interesariuszy i diagramami UML.

Po drugie — **zdefiniowany zakres funkcjonalny** — wiemy dokładnie, co system ma robić.

Po trzecie — **działający prototyp interfejsu** — logowanie, zadania, drag and drop, przypisywanie osób.

Po czwarte — **podstawa backendu** — autentykacja użytkowników w PHP i MySQL.

Research Planner to solidna **analiza biznesowa z proof-of-concept interfejsu**. Kolejny etap to rozbudowa backendu i modułów biznesowych zgodnie z dokumentacją.

Dziękujemy za uwagę. Chętnie odpowiemy na pytania.

**[Pauza — czekaj na pytania]**

---

## SLIDE 13 (opcjonalny) — Harmonogram (~1 min)

Jeśli zapytają o postęp prac w czasie — możesz pokazać ten slajd.

Etapy pierwszy i drugi — analiza wymagań — zostały ukończone. Etapy trzeci i czwarty — projekt systemu z UML — również. Implementacja backendu i frontendu jest na etapie prototypu. Testy automatyczne nie zostały jeszcze napisane. Dokumentacja i prezentacja — w toku, czyli teraz.

---

## SLIDE 14 (opcjonalny) — Ryzyka (~1 min)

Zidentyfikowaliśmy też ryzyka projektu.

Najważniejsze to rozbieżność między dokumentacją a kodem — mitygujemy to jawnym przedstawieniem prototypu jako POC z roadmapą.

Brak persystencji danych — planujemy rozszerzenie bazy.

Przestarzały backend PHP — docelowa migracja do Spring Boot.

Ograniczony zakres demo — skupiamy prezentację na analizie i prototypie UI, nie udajemy pełnego produktu.

---

## Odpowiedzi na typowe pytania

### „Dlaczego Unity zamiast React?”

Unity pozwoliło nam szybko zbudować interaktywny prototyp z drag and drop i dynamicznymi panelami. Docelowy frontend to React — Unity było narzędziem do walidacji koncepcji UI, nie finalnym wyborem technologicznym.

### „Czy dane są zapisywane?”

W prototypie — nie. Zadania istnieją tylko w pamięci sesji. Zapis do bazy to pierwszy punkt roadmapy.

### „Czy system spełnia RODO?”

Wymagania RODO są opisane w dokumentacji. W prototypie nie zaimplementowano jeszcze mechanizmów zgodności — to planowane na etap produkcyjny.

### „Ile czasu zajęła implementacja?”

Zgodnie z harmonogramem: analiza 2 tygodnie, projekt systemu 2 tygodnie, implementacja prototypu — około 5 tygodni pracy zespołu.

### „Czy można to uruchomić na telefonie?”

Mobilna wersja natywna jest poza zakresem projektu — zapisane w Karcie projektu. Unity teoretycznie pozwala na build mobilny, ale nie był to cel tego etapu.

### „Co było najtrudniejsze?”

Po stronie analitycznej — doprecyzowanie wymagań dla pięciu różnych ról. Po stronie technicznej — implementacja drag and drop między dynamicznymi listami zadań w Unity.

---

## Timing — ściągawka

| Slajd | Temat | Czas |
|-------|-------|------|
| 1 | Tytuł | 1 min |
| 2 | Problem | 2 min |
| 3 | Zakres | 2,5 min |
| 4 | Interesariusze | 3 min |
| 5 | Wymagania | 3 min |
| 6 | UML | 3 min |
| 7 | Architektura | 2,5 min |
| 8 | Implementacja | 2 min |
| 9 | Przejście do demo | 0,5 min |
| — | **DEMO** | **8 min** |
| 10 | Kod | 2 min |
| 11 | Luki | 2,5 min |
| 12 | Podsumowanie | 2 min |
| — | Pytania | 2–3 min |
| **RAZEM** | | **~33 min** |

> Jeśli masz tylko 20 min — pomiń slajdy 5 i 10, skróć demo do 5 min.
