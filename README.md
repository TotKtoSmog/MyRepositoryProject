# MyRepositoryProject

## Практическая работа №2. CI/CD

1.	Настройте систему непрерывной интеграции (CI) для вашего проекта, например, используя сервисы GitHub Action, GitLab CI/CD, Jenkins, Travis, CI или другие инструменты. Пример «Настройка CI с помощью GitHub Actions»:
    -	 Откройте репозиторий проекта на GitHub. Перейдите во вкладку «Actions» в верхней части страницы репозитория. Нажмите на кнопку «Set up a workflow yourself» или выберите один из шаблонов для создания нового workflow.
    - Создайте файл с названием main.yml в папке .github/workflows/ вашего репозитория и определите в нем шаги вашего CI/CD процесса.
    - Сделайте коммит и отправьте изменения в ваш репозиторий на GitHub.
    - Проверка работы CI: после отправки изменений в репозиторий, перейдите во вкладку «Actions» на GitHub. Отобразите в отчете список запущенных workflow и их статус. Проверьте лoг выполнения шагов вашего CI/CD процесса.
2.	Настройте CI таким образом, чтобы он автоматически запускался при каждом новом коммите в ваш репозиторий.
3.	Добавьте скрипты для тестирования вашего проекта (например, unit-тесты, интеграционные тесты) и убедитесь, что они успешно проходят при запуске через CI.
4.	Создайте ветку Development для разработки новых функций и исправлений.
5.	Разработайте новую функцию или исправление ошибки в вашем проекте и закоммитьте изменения в ветку development.
6.	Убедитесь, что CI успешно запустился после коммита в ветку development и прошел все тесты.
7.	Создайте Pull Request (PR) для вливания изменений из ветки development в основную ветку (например, main).
8.	Настройте автоматическое тестирование и слияние PR при успешном прохождении всех тестов.
9.	Проверьте, что изменения из ветки development успешно влилось в основную ветку с помощью CI/CD.
10.	Создайте ветку release для подготовки к выпуску новой версии вашего проекта.
11.	Подготовьте все необходимые изменения (например, обновление версии, исправление багов) в ветке release.
12.	Убедитесь, что CI успешно запустился после коммита в ветку release и все тесты прошли успешно.
13.	Создайте новый тег для версии вашего проекта и опубликуйте его на платформе Git.
14.	Создайте документацию к вашему проекту и добавьте ее в репозиторий.
15.	Настройте автоматическую генерацию документации при каждом обновлении кода через CI/CD.
16.	Проверьте, что документация успешно обновляется при каждом изменении кода.
17.	Заключите текущую версию проекта и завершите работу на лабораторную работу.
