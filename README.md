# Генератор паролей (PasswordGenerator)
## Краткое описание ПО
__Генератор паролей__ — приложение для создания паролей, которые могут содержать различные символы (буквы верхнего и нижнего регистров, цифры и специальные символы). Пользователи могут выбрать длину пароля и указать, какие элементы должны быть использованы при его генерации.
## Инструкция по установке
Для установки генератора паролей необходимо выполнить следующие шаги:
1. Скачайте [готовый файл](https://github.com/YanaZaletova/EPP_PasswordGenerator/blob/dev/PasswordGenetator.exe)
2. Дважды кликните на файл для его запуска
 
Если файл не запускается, проверьте, установлена ли версия [.NET Framework 4.7.2](https://dotnet.microsoft.com/ru-ru/download/dotnet-framework/net472) или выше.
## Инструкция по сборке
Для сборки генератора паролей необходимо выполнить следующие шаги:
1. Проверьте, установлена ли у вас [Microsoft Visual Studio](https://visualstudio.microsoft.com/ru/) с поддержкой языка разработки C#
2. Клонируйте репозиторий:
```
git clone https://github.com/username/repository.git
```
3. Перейдите в папку с проектом и откройте файл проекта `EPP_PasswordGenerator.sln` в Visual Studio
4. В Visual Studio выберите `Сборка` > `Собрать проект`, либо используйте сочетание клавиш `Ctrl+Shift+B`, чтобы собрать проект
5. Запустите программу через исполнимый файл в папке `bin\Release`, либо через сочетание клавиш `Ctrl+F5`
## Документация
### Основные функции  

1. __Выбор длины пароля__ - можно выбрать одну из предоставленных длин пароля (8, 8-14, 14-20), либо ввести длину вручную
2. __Настройка используемых символов__ - можно выбрать используемые символы в пароле:
   - Буквы верхнего регистра (A-Z)
   - Буквы нижнего регистра (a-z)
   - Цифры (0-9)
   - Специальные символы (!@#$%^&?*()_-+=<>)
3. __Сгенерировать пароль__ - нажмите кнопку `Сгенерировать`, чтобы создать пароль

### Описание логики работы программы
-  __Обработка событий__ - все элементы интерфейса обрабатывают события изменения. При изменении длины пароля или выборе дополнительных символов программа автоматически обновляет кнопку `Сгенерировать`. Когда пользователь изменяет длину пароля вручную, соответствующие чекбоксы очищаются, чтобы предотвратить возможные ошибки
-  __Генерация пароля__ - для генерации используется класс `Random`, который выбирает случайные символы из набора. Пароль генерируется поэтапно: сначала добавляются хотя бы по одному символу каждого типа, если пользователь выбрал этот параметр, а затем случайным образом заполняются оставшиеся символы
-  __Перемешивание пароля__ - после того как строка пароля сформирована, она случайным образом перемешивается, чтобы гарантировать, что символы будут расположены в случайном порядке. Для этого используется алгоритм случайного обмена символами внутри массива символов
## Инструкция по совместной работе
1. Создайте форк репозитория
2. Клонируйте ваш форк и создайте ветку для разработки:
```
git clone https://github.com/username/repository.git
```
```
git checkout -b branch
```
3. После завершения вашей работы отправьте изменения в ваш форк:
```
git add .
```
```
git commit -m "Описание изменений"
```
```
git push origin branch
```
4. Перейдите на страницу вашего форка на GitHub и создайте `Pull Request` в оригинальном репозитории
## Информация об авторских правах и лицензировании  
Этот проект распространяется под лицензией MIT. С полными условиями лицензии можно ознакомиться [здесь](https://github.com/YanaZaletova/EPP_PasswordGenerator/tree/doc?tab=License-1-ov-file).  
