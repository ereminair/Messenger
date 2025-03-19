# Разработчик образовательных программ
реализация модели дизайнера образовательной программы

## Отработанный материал

Основные принципы ООП, SOLID, GRASP, порождающие паттерны

## Цель проекта

Отработать реализацию порождающих паттернов, применить их совместно с ранее изученным материалом.

## Задание

- реализовать модель конструктора образовательных программ
- покрыть полученное решение тестами

## Формулировка

Некоторый абстрактный университет проектирует систему для формирования и редактирования образовательных программ. Вам
необходимо спроектировать предметную область для реализации данного функционала.

В системе присутствуют: пользователи, лабораторные, лекционные материалы, критерии оценивания, предметы, сами
образовательные программы.

## Функциональные требования

### Пользователь

- Имеет идентификатор и имя
- Привязан к последующим создаваемым сущностям в качестве автора

### Лабораторная работа

- Имеет: идентификатор, наименование, описание, критерии оценивания, количество баллов
- Также имеет автора
- Лабораторную работу можно создать на основе уже существующей, в таком случае она должна хранить идентификатор
  лабораторной, взятой за основу
- Лабораторная может быть изменена, но сделать это может только её автор, при этом количество баллов неизменно

### Лекционные материалы

- Имеют: идентификатор, наименование, краткое описание, контент (строковый)
- Также имеют автора
- Лекционные материалы можно создать на основе уже существующих, в таком случае они должны хранить идентификатор
  лекционных материалов, взятых за основу
- Лекционные материалы могут быть изменены, но сделать это может только их автор

### Предмет

- Имеет: идентификатор, название, список лабораторных работ, список лекционных материалов
- Также имеет автора
- К предметам привязан зачётный формат: экзамен или зачет
- В случае, когда предмет имеет экзамен, он должен содержать количество баллов
- В случае, когда предмет имеет зачёт, он должен содержать информацию о минимальном количестве баллов, необходимых для
  получения этого зачёта
- Предмет можно создать на основе уже существующих, в таком случае он должен хранить идентификатор предмета, взятого за
  основу
- Предмет может быть изменён, но сделать это может только его автор, при этом списко лаборторных работ поменять нельзя, как и количество баллов за экзамен
- Суммарное количество баллов предмета должно ровнятся 100

### Образовательная программа

- Имеет: идентификатор, название, список предметов
- Предметы должны быть привязаны к определённым семестрам
- Также имеет ответственное лицо, руководителя программы

## Нефункциональные требования

- Реализации создания сущностей на основе предыдущих должны использовать различные порождающие паттерны
- Для сущностей должны быть реализованы репозитории, хранящие созданные объекты и осуществляющие поиск по их
  идентификаторам
- При использовании абстракций, не должно быть необходимости указывать автора каждый раз при сборке новых сущностей

> Репозиторий – тип, ответсвенный за хранение, добавление и поиск каких-либо сущностей. В данной лабораторной вам необхоимо сделать in-memory реализацию (основанную на листе или словаре, например), которая просто позволяет отслеживать определённые сущности и потом их искать.

## Тестовые сценарии

- Попытки изменения сущностей не автором – возвращают ошибки
- После создания сущностей на основе существующих, копии должны содержать идентификаторы исходника
- При создании предмета, с количеством баллов не равное 100 – возвращается ошибка

## Определение готовности

- реализованы все функциональные и не функциональные требования
- реализованы все необходимые юнит-тесты
- в реализации лабораторной используются порождающие паттерны
- реализация не нарушает принципы SOLID, следует основным концепциям ООП
