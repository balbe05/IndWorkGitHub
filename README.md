![Логотип](https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgiccmklR21x2GxZ9LEbKOxO_AIupvBnc8kg&s "Логотип GitHub")\
![Логотип](https://camo.githubusercontent.com/8693bde04030b1670d5097703441005eba34240c32d1df1eb82a5f0d6716518e/68747470733a2f2f63646e2e7261776769742e636f6d2f73696e647265736f726875732f617765736f6d652f643733303566333864323966656437386661383536353265336136336531353464643865383832392f6d656469612f62616467652e737667)
![Логотип](https://camo.githubusercontent.com/f7740da3e954f815cc3c81f51c18a0138cfc9fe35b3e16108cbab9bf749b03db/68747470733a2f2f696d672e736869656c64732e696f2f646973636f72642f3733333032373638313138343235313933372e7376673f7374796c653d666c6174266c6162656c3d4a6f696e253230436f6d6d756e69747926636f6c6f723d373238394441)
![Логотип](https://camo.githubusercontent.com/2ebaf114252ac1a9e0232e6adf119c1b95105921f2287097a2b74ed93ab8dca0/68747470733a2f2f696d672e736869656c64732e696f2f6769746875622f73746172732f616268697368656b6e61696964752f617765736f6d652d6769746875622d70726f66696c652d726561646d65)
![Логотип](https://camo.githubusercontent.com/af5d188f921c385e0d3ced85dd5dae68c3c5b6d042c8601de32cf3d8ebfb2823/68747470733a2f2f696d672e736869656c64732e696f2f6769746875622f666f726b732f616268697368656b6e61696964752f617765736f6d652d6769746875622d70726f66696c652d726561646d65)

# Разработка и администрирование базы данных платформы по продаже автомобиля
# Введение
Данное приложение сделано для облегчения покупки и продажи автомобилей, а также услуг обмена автомобилями. Оно предоставляет платформу для пользователей, чтобы просматривать, создавать и управлять списками автомобилей.
# Необходимые условия для использования продукта
1. Операционная система Windows 10 и выше
2. MS SQL SERVER
3. ASP .NET CORE\
![Логотип](https://img.icons8.com/?size=100&id=48455&format=png&color=000000)
![Логотип](https://img.icons8.com/?size=100&id=laYYF3dV0Iew&format=png&color=000000)
![Логотип](https://img.icons8.com/?size=100&id=121835&format=png&color=000000)
# Как установить программу
1. Клонировать репозиторий: git clone https://github.com/your-username/car-exchange-api.git
2. Установить зависимости: npm install
3. Запустить сервер: npm start
4. Использовать инструмент, такой как Postman or cURL, для тестирования конечных точек API
# Порядок использования
1. Регистрация пользователя (создать аккаунт, придумать пароль и логин, затем войти под своим аккаунтом)
2. Создание объявление о продаже/обмене автомобиля, используя конечную точку POST /listings
3. Просмотр списка объявлений, используя конечную точку GET /listings
4. Добавление объявления в избранное, используя конечную точку GET /listings/:id
5. Оценка и отзыв об авторе после покупки/обмена, используя систему рейтинга и отзывов