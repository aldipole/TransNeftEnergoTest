# TransNeftEnergoTest WebService
Результаты выполнения задания

## Задание 1.1

Создайте модели классов по приведенной схеме: `TransNeftEnergoTest.DAL.Models`

Создайте структуры базы данных: `TransNeftEnergoTest.DAL.DatabaseContext`

Создайте класс по инициализации БД тестовыми данными: `TransNeftEnergoTest.DBInitializer`

## Задание 1.2
Создайте API для получения следующей выборки данных: `TransNeftEnergoTest.API`

1.  Добавить новую точку измерения с указанием счетчика, трансформатора тока и трансформатора напряжения

    POST: `/api/measurement-points`,
    BODY: `TransNeftEnergoTest.DTO.MeasurementPointDTO`

2.  Выбрать все расчетные приборы учета в 2018 году

    GET: `/api/accounting-devices/{year}`

3.  По указанному объекту потребления выбрать все счетчики с закончившимся сроком поверки

    GET: `/api/consumption-units/{consumption-units-id}/electricity-meters/expired`

4.  По указанному объекту потребления выбрать все трансформаторы напряжения с закончившимся сроком поверки

    GET: `/api/consumption-units/{consumption-units-id}/current-meters/expired`

5.  По указанному объекту потребления выбрать все трансформаторы тока с закончившимся сроком поверки

    GET: `/api/consumption-units/{consumption-units-id}/voltage-meters/expired`
