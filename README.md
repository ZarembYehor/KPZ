# Для початку розглянемо принцип Single Responsibility Principle
Він використовується одразу в багатьох класах
[https://github.com/ZarembYehor/KPZ/blob/fb88168c1a10bb93913691adfe0b1f1838f699cb/lab1/lab1/Money.cs#L25](https://github.com/ZarembYehor/KPZ/blob/fb88168c1a10bb93913691adfe0b1f1838f699cb/lab1/lab1/Money.cs#L25-L33)https://github.com/ZarembYehor/KPZ/blob/fb88168c1a10bb93913691adfe0b1f1838f699cb/lab1/lab1/Money.cs#L25-L33
В цьому випадку розділяється дія на два методи, створює  рядок для виведення, а інший здійснює вивід.
https://github.com/ZarembYehor/KPZ/blob/fb88168c1a10bb93913691adfe0b1f1838f699cb/lab1/lab1/Product.cs#L41-L59
В цьому випадку перевірку на те чи є дійсним значення в результаті віднімання здійснює 1 метод, а саме віднімання здійсенює інший.
# Принцип Liskov Substitution Principle
https://github.com/ZarembYehor/KPZ/blob/fb88168c1a10bb93913691adfe0b1f1838f699cb/lab1/lab1/Program.cs#L23-L27
https://github.com/ZarembYehor/KPZ/blob/fb88168c1a10bb93913691adfe0b1f1838f699cb/lab1/lab1/Program.cs#L33-L34
Використання дочірніх класів замість батьківського при створенні екземплярів інших класів
# Принцип Dependency Inversion Principle, DIP
Більш детальні валюти базуються на класі Money, котрий не маэ конкретики
https://github.com/ZarembYehor/KPZ/blob/fb88168c1a10bb93913691adfe0b1f1838f699cb/lab1/lab1/Dollar.cs#L9-L29
База береться з уособленого класу та далі деталізується
# Принцип Fail Fast: падай швидко
Використовується 1 раз в коді при перевірці на додатність валюти, коли при невірному введенні викидується помилка
https://github.com/ZarembYehor/KPZ/blob/fb88168c1a10bb93913691adfe0b1f1838f699cb/lab1/lab1/Money.cs#L14-L23
# Принцип Interface Segregation Principle, ISP
Відсутній, бо інтерфейси не використовуються
# Принцип відкритості/закритості (Open/Closed, OCP)
https://github.com/ZarembYehor/KPZ/blob/fb88168c1a10bb93913691adfe0b1f1838f699cb/lab1/lab1/Euro.cs#L30-L33
Відсутній, бо в дочірніх класах змінюється метод ToString батьківського класу
# Принцип Composition over Inheritance
Класи Product, Warehouse та Reporting використовують інші класи, замість того, щоб їх наслідувати

Клас Warehouse міг наслідувати Product, вле з метою меншої залежності я вирішив не робити його класом нащадком, що дозволило без проблем додати поле category до Product.
https://github.com/ZarembYehor/KPZ/blob/b2f269fe39e2b34133b986afbf5d8208409edc91/lab1/lab1/Warehouse.cs#L15-L24
https://github.com/ZarembYehor/KPZ/blob/b2f269fe39e2b34133b986afbf5d8208409edc91/lab1/lab1/Product.cs#L9-L18
https://github.com/ZarembYehor/KPZ/blob/b2f269fe39e2b34133b986afbf5d8208409edc91/lab1/lab1/Reporting.cs#L9-L20
# Принцип DRY: не повторюйся (Don’t repeat yourself)
Не у всьому коді, але в якійсь частині використовувався
https://github.com/ZarembYehor/KPZ/blob/b2f269fe39e2b34133b986afbf5d8208409edc91/lab1/lab1/Hryvnia.cs#L31-L44
Під час написання коду у цьому елементі було один метод розбито на два і два великих рядки ToString, котрі були на два варіанти стали 1 рядком зі змінюваною частиною.
І завдяки використанню минулих принципів був частково виконаний цей, так як не прийшлось переписувати код при додавання поля category та при підстановці класів дочірніх до класу Money, відрізки коду були наведені при розляданні попередніх принципів.
# YAGNI
Класи використовують тільки ті методи та властивості, котрі потрібні для завдання, себто код відповідає цьому принципу(принаймні мені так здається)
# KISS
Весь код побудований на невеликих методах з неважкими рішеннями, але є проблемний нагромаджений елемент, котрий є поганим для розуміння
https://github.com/ZarembYehor/KPZ/blob/b2f269fe39e2b34133b986afbf5d8208409edc91/lab1/lab1/Reporting.cs#L22-L57
# Program to Interfaces not Implementations
Код не використовує інтерфейси, тому він не відповідає цьому принципу
