# Prezentacja do przeczytania — Jarosław Abramek, Analityk

> **Czas:** ok. 25–30 minut (bez demo) lub 33–38 minut (z demo ~8 min)  
> **Rola:** Analityk — modelowanie procesów, wymagania, przypadki użycia, UML  
> **Wskazówka:** Tekst możesz czytać naturalnie — nie musisz trzymać się co do słowa.

---

## WSTĘP (~2 min)

Dzień dobry.

Nazywam się **Jarosław Abramek** i w projekcie **Research Planner** pełnię rolę **analityka**. Odpowiadałem za analizę wymagań, identyfikację interesariuszy, opis procesów biznesowych oraz opracowanie diagramów przypadków użycia w notacji UML.

Projekt realizowany był w dwóch etapach. **Pierwsza część** — od października 2025 do stycznia 2026 — to faza analityczna i projektowa. **Druga część** — od marca do czerwca 2026 — to faza implementacji prototypu w środowisku Unity.

Dzisiaj przedstawię obie te fazy: najpierw to, co udało się opracować analitycznie, a potem jak te wymagania przełożyły się — lub nie przełożyły — na działający prototyp.

Zacznijmy od kontekstu biznesowego.

---

## CZĘŚĆ I — PROBLEM I CEL PROJEKTU (~3 min)

### Dlaczego powstał Research Planner?

Podczas analizy wstępnej zidentyfikowaliśmy typowy problem zespołów badawczych: praca jest rozproszona między wiele narzędzi. Zadania trafiają do Excela, komunikacja odbywa się mailem lub na komunikatorach, raporty powstają w osobnych dokumentach, a budżet jest śledzony w innych plikach.

Skutki tego są przewidywalne:
- brak jednego obrazu sytuacji w projekcie,
- opóźnienia i gubione terminy,
- trudności w rozliczeniach finansowych,
- ograniczona przejrzystość dla osób nadzorujących badania.

**Celem projektu** było stworzenie centralnego systemu do planowania, realizacji, monitorowania i rozliczania projektów badawczych — niezależnie od ich charakteru: naukowego, komercyjnego czy edukacyjnego.

Jako analityk miałem za zadanie zdefiniować, **kto** będzie korzystał z systemu, **czego** potrzebuje i **jak** powinny wyglądać kluczowe procesy.

---

## CZĘŚĆ I — INTERESARUSZE (~4 min)

### Pięć ról użytkowników

W dokumencie `AnalizaWymagan.md` zidentyfikowaliśmy **pięciu interesariuszy**. Każda rola ma inne potrzeby i inny zakres odpowiedzialności.

**1. Opiekun**  
Osoba nadzorująca projekt z perspektywy strategicznej. Nie zarządza codzienną pracą, ale monitoruje wyniki, harmonogramy i akceptuje raporty przed przekazaniem ich instytucjom finansującym — na przykład grantodawcom.

**2. Kierownik projektu**  
Główny planista konkretnego badania. Odpowiada za strukturę prac, harmonogram, budżet i raportowanie operacyjne. To centralna rola w module planowania.

**3. Lider zespołu**  
Koordynuje codzienną pracę zespołu. Formuje grupy robocze, deleguje zadania, monitoruje postępy i komunikuje się z członkami zespołu.

**4. Członek zespołu**  
Bezpośredni wykonawca zadań. Raportuje postępy, realizuje przypisane podzadania i korzysta z modułów komunikacyjnych.

**5. Księgowa**  
Odpowiada za stronę finansową: budżet, faktury, płatności, weryfikację zamówień i raporty kosztowe.

Ta pięciopodziałowa strukt ról była fundamentem dalszej analizy. Każda rola została opisana osobno pod kątem wymagań funkcjonalnych.

---

## CZĘŚĆ I — WYMAGANIA FUNKCJONALNE (~4 min)

### Co system ma robić?

Dla każdego interesariusza zdefiniowaliśmy wymagania z oznaczeniem priorytetu — **wymagane** lub **średni** priorytet.

**Opiekun** — cztery kluczowe wymagania:
- nadzór nad realizowanym projektem,
- podgląd wyników prac zespołów,
- monitoring harmonogramów,
- akceptacja kamieni milowych i raportów.

**Kierownik projektu** — między innymi:
- zarządzanie strukturą prac — dodawanie, edycja i usuwanie zadań,
- planowanie czasowe i harmonogram,
- zarządzanie zapotrzebowaniem na sprzęt i materiały,
- raportowanie operacyjne.

**Lider zespołu** — najszerszy zestaw wymagań:
- dodawanie i formowanie zespołów,
- delegowanie zadań,
- kontrola operacyjna postępów,
- komunikacja wewnętrzna,
- raportowanie wyników,
- składanie wniosków o zapotrzebowanie.

**Księgowa** — moduł finansowy:
- planowanie i monitoring budżetu,
- rejestrowanie faktur,
- realizacja płatności,
- weryfikacja zamówień,
- analiza finansowa i raporty kosztowe.

**Członek zespołu**:
- raportowanie postępów,
- obsługa powiadomień,
- wymiana informacji w module komunikacyjnym,
- opcjonalnie — rejestrowanie czasu pracy.

Łącznie zdefiniowaliśmy **ponad dwadzieścia wymagań funkcjonalnych**, pogrupowanych według ról.

---

## CZĘŚĆ I — WYMAGANIA NIEFUNKCJONALNE (~2 min)

Oprócz funkcji biznesowych opisaliśmy też **dziewięć wymagań niefunkcjonalnych**, które określają jakość systemu:

1. Dostępność 24/7  
2. Czas reakcji poniżej 1 sekundy (Karta projektu podawała ogólniej ≤ 3 s)  
3. Szyfrowanie danych — TLS/SSL  
4. Ochrona modułów finansowych przed nieautoryzowanym dostępem  
5. Skalowalność — obsługa wielu projektów i użytkowników  
6. Zgodność z RODO i przepisami finansowymi  
7. Standardy WCAG — dostępność interfejsu  
8. Czytelna architektura kodu ułatwiająca rozwój  
9. Obsługa sytuacji braku danych — system ma instruować użytkownika, a nie wyświetlać pusty błąd  

Te wymagania zostały zapisane w `AnalizaWymagan.md` i stanowią punkt odniesienia dla implementacji oraz testów akceptacyjnych.

---

## CZĘŚĆ I — PRZYPADKI UŻYCIA I DIAGRAMY UML (~5 min)

### Modelowanie procesów

Kolejnym krokiem analizy było przełożenie wymagań na **przypadki użycia** ze scenariuszami głównymi i alternatywnymi.

Dla roli **Opiekuna** opracowaliśmy cztery przypadki użycia:
- nadzór nad realizowanym projektem,
- akceptacja kamieni milowych i raportów,
- podgląd wyników,
- monitoring harmonogramów.

Każdy przypadek ma zdefiniowane: aktorów, warunki początkowe, scenariusz główny krok po kroku oraz scenariusze alternatywne — na przykład brak projektów w systemie lub brak uprawnień.

**[Pokaż diagram: `diagramy/aktor-opiekun.png`]**

Na slajdzie widzicie diagram UML dla Opiekuna. Widać tu powiązania między aktorem a przypadkami użycia oraz zależności include i extend.

---

Dla **Kierownika projektu** opisaliśmy przypadki takie jak:
- zarządzanie strukturą prac,
- zarządzanie zapotrzebowaniem,
- raportowanie operacyjne,
- tworzenie harmonogramu z przypisywaniem zadań do etapów.

**[Pokaż diagram: `image-6.png`]**

Scenariusze uwzględniają walidację — na przykład błędne daty, brak środków w budżecie czy odrzucenie zamówienia przez księgową.

---

Dla **Lidera zespołu** zdefiniowaliśmy sześć przypadków:
- dodawanie członków zespołów,
- formowanie zespołów,
- delegowanie zadań,
- kontrola operacyjna,
- komunikacja wewnętrzna,
- raportowanie wyników i składanie wniosków o zapotrzebowanie.

**[Pokaż diagram: `image-7.png`]**

---

**Uwaga analityczna:** Dla ról **Księgowej** i **Członka zespołu** mamy opisane wymagania funkcjonalne, ale **nie opracowaliśmy jeszcze pełnych scenariuszy przypadków użycia ani diagramów UML**. To jedna z luk dokumentacyjnych, którą należałoby uzupełnić w kolejnej iteracji projektu.

Diagramy i specyfikacje przypadków użycia stanowią **bezpośrednią podstawę** do projektowania modułów systemu — każdy przypadek można przełożyć na ekran, endpoint API lub regułę biznesową.

---

## CZĘŚĆ I — KARTA PROJEKTU I ZAKRES (~2 min)

Wyniki analizy zostały zebrane w **Karcie projektu** — dokumencie, który definiuje:

- cel i uzasadnienie biznesowe,
- zakres — co jest w projekcie, a co poza nim,
- planowany stos technologiczny: **Java i Spring Boot** po stronie backendu, **React i TypeScript** po stronie frontendu, **PostgreSQL** jako baza danych,
- harmonogram jedenastu tygodni — od analizy przez implementację po testy i prezentację,
- ryzyka — między innymi opóźnienia, niedoprecyzowane wymagania i brak doświadczenia w React,
- kryteria sukcesu — implementacja kluczowych funkcji, stabilne działanie, zgodność z RODO, pełna dokumentacja.

Jako analityk współtworzyłem tę dokumentację i dbałem o spójność między Kartą projektu a Analizą wymagań.

**Pierwsza część projektu zakończyła się kompletną specyfikacją biznesową i modelem procesów.** Przeszliśmy do drugiej fazy — implementacji.

---

## PRZEJŚCIE DO CZĘŚCI II (~1 min)

W **marcu 2026** rozpoczęła się druga część projektu. Skład zespołu uległ zmianie, a ze względu na ograniczenia organizacyjne podział ról został ustalony w innej konfiguracji niż w pierwszej fazie. Według Raportu zamknięcia: **Janusz Lejtan** — kierownik zespołu, **Jarosław Abramek** — analityk, **Artur Matuszewski** — programista, **Piotr Kotarski** — dokumentalista.

Ja pozostałem na stanowisku **analityka** — moim zadaniem było nadal doprecyzowywanie wymagań i wsparcie zespołu implementacyjnego. Główna praca programistyczna została podjęta w środowisku **Unity**, co było odstępstwem od pierwotnie planowanej architektury webowej.

Jako analityk chcę teraz pokazać, **które wymagania z naszej specyfikacji udało się zrealizować w prototypie**, a które pozostały na etapie dokumentacji.

---

## CZĘŚĆ II — CO ZOSTAŁO ZAIMPLEMENTOWANE (~4 min)

### Prototyp Unity — mapowanie na wymagania

W drugiej części powstał **działający prototyp interfejsu** w Unity 2022.3. Z perspektywy analityka przeanalizowałem, które elementy naszej specyfikacji są w nim odzwierciedlone.

| Wymaganie z analizy | Realizacja w prototypie | Ocena |
|---------------------|-------------------------|-------|
| Logowanie użytkownika | Kod logowania w `ASUPro_Core.cs` (gotowy pakiet ASUPro); zbudowana aplikacja startuje bez ekranu logowania | ⚠️ Tylko w kodzie |
| Zarządzanie strukturą prac | Paski zadań + karty zadań | ✅ Prototyp UI |
| Planowanie czasowe | Pole `endDate` w modelu zadania, brak pola daty w edytorze | ⚠️ Tylko w modelu |
| Delegowanie zadań | Przypisanie osoby do zadania | ✅ Działa |
| Formowanie zespołów | Lista członków zespołu | ⚠️ Tylko demo (1 użytkownik) |
| Reorganizacja zadań | Drag & drop między paskami | ✅ Działa |
| Nadzór Opiekuna | — | ❌ Brak |
| Moduł finansowy Księgowej | — | ❌ Brak |
| Harmonogram Gantta | — | ❌ Brak |
| Raportowanie | — | ❌ Brak |
| Role i uprawnienia | — | ❌ Brak |
| Zapis danych do bazy | Skrypty PHP + schemat `asupro.sql` (tylko tabela użytkowników), niepodłączone | ❌ Brak persystencji |

**Wnioski analityczne:**

Z pięciu ról interesariuszy prototyp dotyka głównie obszarów **Kierownika projektu** i **Lidera zespołu** — zarządzanie zadaniami i delegowanie. Moduły Opiekuna, Księgowej i większość funkcji Członka zespołu **nie zostały zaimplementowane**.

To nie znaczy, że analiza była zbędna — przeciwnie, prototyp UI **potwierdza sensowność** koncepcji pasków zadań jako etapów projektu i przypisywania osób do zadań. Wiemy też dokładnie, co trzeba zbudować dalej.

---

## CZĘŚĆ II — PRZEGLĄD TECHNICZNY (perspektywa analityka) (~2 min)

Jako analityk współpracowałem z programistą przy mapowaniu wymagań na komponenty systemu. W prototypie wyróżniamy:

- **Manager** — zarządza listą członków zespołu (w prototypie jeden użytkownik demo „Janusz”) i przełączaniem paneli,
- **TaskBar** — reprezentuje etap lub kategorię prac w projekcie,
- **TaskCell** — pojedyncze zadanie z nazwą, opisem, przypisaną osobą i polem terminu (termin jest w modelu, ale nie w interfejsie),
- **TaskConfigurator** — formularz edycji zadania,
- **Dragme** — mechanizm przenoszenia zadań między etapami,
- **ASUPro_Core** — logowanie; pochodzi z gotowego pakietu ASUPro, podobnie jak skrypty PHP.

Uczciwie o backendzie: skrypty `Login.php` i `Register.php` to przykładowy kod z pakietu (w nagłówku „CREATED BY JAKE”). Używają API `mysql_*`, które usunięto w PHP 7, a `Config.php` jest pusty — backend nie jest podłączony. Z perspektywy wymagań RODO i TLS to istotna luka: hasła są zapisywane jawnym tekstem.

W kodzie z kwietnia 2026 dodano **komentarze dokumentujące** logikę tych komponentów — to ułatwia dalszą analizę i rozwój systemu.

Warto też zaznaczyć: pliki `GetScores.cs` i `InsertScore.cs` to **szkielet komunikacji HTTP** z tutoriala — nie są jeszcze podłączone do logiki Research Planner. Jako analityk zanotowałem to jako lukę między zamierzoną persystencją danych a stanem faktycznym.

---

## CZĘŚĆ II — DEMO NA ŻYWO (~8 min)

**[Uruchom `ResearchPlanner.exe` — szczegóły w `Demo-checklist.md`]**

Teraz pokażę, jak wygląda prototyp w praktyce. Będę komentować go przez pryzmat wymagań, które sami zdefiniowaliśmy.

---

**Krok 1 — Tablica zadań**

Uruchamiam aplikację. Od razu widzimy główną tablicę — „TASKbar ORGANIZER 5000”. Ekranu logowania w zbudowanej wersji nie ma: kod logowania istnieje w `ASUPro_Core.cs`, ale prototyp startuje bezpośrednio na tablicy.

---

**Krok 2 — Paski zadań**

Klikam **ADD TASK BAR** dwa razy. Każdy pasek ma inny kolor — to wizualna reprezentacja **etapu projektu**.

W naszej analizie Kierownik projektu definiuje strukturę prac i przypisuje zadania do etapów harmonogramu. Paski zadań w prototypie są właśnie taką strukturą — uproszczoną, ale zgodną z modelem procesów.

---

**Krok 3 — Tworzenie i edycja zadania**

Klikam **NEW TASK** — pojawia się karta. Klikam w nią i otwiera się edytor zadania.

Wpisuję krótki tytuł, np. **„Analiza”**, i opcjonalnie treść w polu Task Content.

To realizuje wymaganie *„zarządzanie strukturą prac”* — w wersji prototypowej, bez zapisu do bazy. Wymaganie *„planowanie czasowe”* jest przygotowane tylko w modelu danych: zadanie ma pole terminu, ale w edytorze nie ma jeszcze pola daty.

---

**Krok 4 — Delegowanie zadania**

Klikam **+** przy „Assign Person”, wybieram **Janusz**, zamykam okno i zapisuję czerwoną dyskietką.

Na karcie zadania pojawia się jego nazwa. To odpowiada przypadkowi użycia Lidera zespołu: *„Zarządzanie strukturą prac i delegowanie zadań”*. W prototypie jest jeden użytkownik demo — w pełnej wersji byłaby tu baza pracowników, tak jak opisaliśmy w przypadku użycia „Dodawanie członków zespołów”. Po przypisaniu system wysyłałby też powiadomienie — to mamy w scenariuszu, ale nie w kodzie.

---

**Krok 5 — Drag & drop**

Przeciągam kartę zadania na drugi pasek. Zadanie zmienia etap projektu i przyjmuje kolor nowego paska.

To pokazuje elastyczność interfejsu — Kierownik lub Lider może reorganizować prace, gdy zmieniają się priorytety. W analizie opisaliśmy podobną logikę przy przypisywaniu zadań do etapów harmonogramu.

---

**[Zamknij aplikację]**

To była demonstracja prototypu. Jak widać, pokrywa on **wąski fragment** naszej pełnej specyfikacji — głównie moduł zadań i delegowania. Reszta wymagań pozostaje do implementacji.

---

**[Pokaz kodu — `ZarzProj/Assets` w edytorze kodu, 3–5 min]**

Na koniec krótko kod źródłowy. `TaskBar.cs` tworzy paski i karty zadań. `TaskCell.cs` to model zadania — widać pola treści, terminu i przypisanej osoby. `TaskConfigurator.cs` wczytuje zadanie do edytora i zapisuje zmiany. `Dragme.cs` odpowiada za przeciąganie — po puszczeniu karta przyczepia się do najbliższego paska. Pełna lista plików w `Demo-checklist.md`.

---

## CZĘŚĆ II — PROBLEMY I RAPORT ZAMKNIĘCIA (~3 min)

### Co poszło nie tak w drugiej fazie?

Jako analityk muszę być uczciwy co do przebiegu drugiej części projektu.

W **Raporcie zamknięcia projektu** — dokumencie z czerwca 2026 — opisano, że projekt został **zakończony przed wdrożeniem**. Główne przyczyny to nie problemy techniczne, lecz **czynniki organizacyjne**:

1. **Problemy komunikacyjne** — nieregularny kontakt między członkami zespołu, brak odpowiedzi na wiadomości w Messengerze,
2. **Zmniejszenie składu zespołu** — część osób przestała aktywnie uczestniczyć w projekcie,
3. **Problemy organizacyjne** — opóźnienia, brak ciągłości prac, przeciążenie pozostałych członków.

Z perspektywy analityka to ważna lekcja: **dobra specyfikacja wymagań nie wystarczy**, jeśli zespół nie ma stabilnej komunikacji i jasnego podziału obowiązków.

W raporcie zalecono na przyszłość:
- jasne zasady komunikacji,
- regularne spotkania statusowe,
- dokumentowanie postępów,
- plan awaryjny na wypadek odejścia kluczowych osób.

Te wnioski są równie ważne jak sama analiza wymagań.

---

## PODSUMOWANIE — CO OSIĄGNĘLIŚMY (~3 min)

### Część I — analiza (moja rola)

- Zidentyfikowaliśmy **5 interesariuszy** z różnymi potrzebami,
- Opisaliśmy **ponad 20 wymagań funkcjonalnych** i **9 wymagań niefunkcjonalnych**,
- Opracowaliśmy **szczegółowe przypadki użycia** dla trzech ról: Opiekuna, Kierownika i Lidera,
- Stworzyliśmy **diagramy UML** przypadków użycia dla trzech ról,
- Spisaliśmy **Kartę projektu** z zakresem, harmonogramem i kryteriami sukcesu.

To solidna podstawa do budowy pełnego systemu Research Planner.

### Część II — prototyp

- Powstał **działający prototyp UI** w Unity — etapy, zadania, delegowanie, drag & drop,
- Potwierdzono **sensowność koncepcji** pasków zadań i przypisywania osób,
- Zidentyfikowano **luki** — brak modułów finansowych, raportowania, ról, persystencji zadań,
- Sporządzono **raport zamknięcia** z wnioskami organizacyjnymi.

### Moja rola jako analityka

W pierwszej części prowadziłem analizę wymagań i modelowanie procesów. W drugiej części wspierałem zespół implementacyjny, mapując wymagania na to, co powstało w prototypie, i dokumentując rozbieżności między specyfikacją a kodem.

---

## ZAMKNIĘCIE (~1 min)

Research Planner to projekt, w którym **analiza biznesowa została wykonana rzetelnie**, a implementacja dotarła do etapu **proof-of-concept interfejsu**. Pełny system opisany w dokumentacji — z modułem finansowym, raportowaniem, harmonogramem Gantta i pięcioma rolami użytkowników — pozostaje do zbudowania w kolejnej iteracji.

Mamy jednak coś cennego: **wiemy dokładnie, co system ma robić**, mamy modele procesów i wiemy, od czego zacząć implementację.

Dziękuję za uwagę. Chętnie odpowiem na pytania.

---

## PYTANIA — gotowe odpowiedzi (dla analityka)

**„Dlaczego nie ma przypadków użycia dla Księgowej?”**  
W pierwszej fazie skupiliśmy się na trzech rolach operacyjnych z największą liczbą interakcji. Wymagania funkcjonalne dla Księgowej i Członka zespołu są opisane, ale pełne scenariusze i diagramy UML pozostały do uzupełnienia — to zanotowana luka.

**„Czy analiza była zgodna z implementacją?”**  
Częściowo. Prototyp pokrywa moduł zadań i delegowania. Moduły finansowe, raportowanie i nadzór Opiekuna — opisane w analizie — nie zostały zaimplementowane z powodów organizacyjnych, nie merytorycznych.

**„Dlaczego Unity zamiast React?”**  
To decyzja zespołu implementacyjnego w drugiej fazie — Unity pozwoliło szybko zbudować interaktywny prototyp. Z perspektywy analityka docelowa architektura webowa z Karty projektu pozostaje aktualna.

**„Gdzie jest logowanie?”**  
Kod logowania jest w `ASUPro_Core.cs` — pochodzi z gotowego pakietu ASUPro i ma wpisany na sztywno użytkownik testowy. Zbudowana aplikacja startuje od razu na tablicy zadań, więc logowania w demo nie pokazujemy.

**„Czy backend działa?”**  
Nie. Skrypty PHP to przykładowy kod z pakietu — używają API `mysql_*`, usuniętego w PHP 7, a konfiguracja bazy (`Config.php`) jest pusta. Hasła byłyby zapisywane jawnym tekstem, co jest sprzeczne z naszymi wymaganiami RODO i szyfrowania. Docelowy backend według Karty projektu to Spring Boot.

**„Czy dane są zapisywane?”**  
Nie — zadania istnieją tylko w pamięci aplikacji i znikają po jej zamknięciu.

**„Czy prowadziliście projekt w Scrumie — Planning, Daily, Retro?”**  
W repozytorium nie ma takiej dokumentacji. Raport zamknięcia opisuje próby wprowadzenia sprintów — wiadomości do zespołu z 29.03 i 22.04.2026 pozostały bez odpowiedzi. To jedna z głównych lekcji projektu: bez regularnej komunikacji proces zwinny nie ruszył.

**„Co byłoby następnym krokiem?”**  
1. Uzupełnienie przypadków użycia dla Księgowej i Członka zespołu,  
2. Rozszerzenie schematu bazy o projekty, zadania i role,  
3. Implementacja modułów zgodnie z priorytetem wymagań „wymagane”.

---

## Ściągawka czasowa

| Sekcja | Czas |
|--------|------|
| Wstęp | 2 min |
| Część I — problem, interesariusze, wymagania | 13 min |
| Część I — UML, karta projektu | 7 min |
| Przejście + Część II — mapowanie, technikalia | 7 min |
| Demo na żywo | 8 min |
| Raport zamknięcia + podsumowanie | 4 min |
| Pytania | 3 min |
| **Razem** | **~44 min z demo** / **~36 min bez demo** |

> Wersja skrócona (25 min): pomiń szczegółowy opis wymagań per rola i skróć demo do 5 min.
