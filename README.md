# Uruchamianie
Aplikacje możemy uruchomić na dwa sposoby. Przez konsole wpisując:
```
./BootcampCoreServices.exe SampleData/jsonData.json
```
jako parametr aplikacji możemy podać ścieżki do plików z danymi w formacie json, xml, csv. Podawane pliki muszą być rozdzilone spacją.

Kolejny sposobem na uruchomienie aplikacji jest kliknięcie dwa razy w plik ```BootcampCoreServices.exe```
Gdy aplikacja sie uruchomi zostanie wyświetlone okno do wyboru pliku z danymi. W przypadku anulowania otwierania pliku aplikacja zakończy działanie.

Po poprawnym wczytaniu pliku otworzy sie główne okno plikacji. Wszystkie błędy podczas wczytywania danych będą pojawiały się w MessageBox-ach.

![OpenFile](https://user-images.githubusercontent.com/36955413/55013424-6612e780-4fe9-11e9-8a6d-88b21c28902b.PNG)

# Instrukcja obsługi
 
![App](https://user-images.githubusercontent.com/36955413/55013647-d3bf1380-4fe9-11e9-9d27-aba4c04afd05.PNG)

### Generowanie raportu
Opcje wygenerowania raportu znajdują się w rozwijanej liście na górze okienka.
Po wybraniu odpowiedniego raportu klikamy przycisk ``` Generuj```. Wygenerowany raport powinien pojawić sie na szarym polu w postaci tabeli z danymi.
Odpowidnio dla każdego raportu widoczne są wymagane do uzupełnienia opcje. Np dla raportu ```j. Ilość zamówień pogrupowanych po nazwie dla klienta o wskazanym identyfikatorze``` wymaganym parametrem jest ```ID klienta```.

Dla raportu ```k. Zamówienia w podanym przedziale cenowym``` wymagane jest podanie przedziału cen.
#### UWAGA! Do pola po lewej stronie zawsze musimy podać liczbę mniejszą niż do prawego, w przeciwnym razie raport nie zostanie wygenerowany.

![App](https://user-images.githubusercontent.com/36955413/55014244-e6861800-4fea-11e9-82e6-90bee4790daf.PNG)

### Sortowanie
Sortowanie jest dostępne tylko dla raportów które zawierają więc niż jeden wiersz.
Sortowanie odbywa się za pomocą wybrania odpowiedniej kolumny na liście rozwijanej, według której chcemy posortować dane. Następnie wybieramy typ sortowania (Rosnąco/Malejąco). Gdy wszystkie opcje zostały ustawione według naszych preferencji, wciśnięcie przycisku ```Generuj``` odpowiednio posortuje dane.
