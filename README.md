# Task_CS_RSSFeedReader

В этом задании было необходимо написать простой RSS-Ридер.
![Скриншот приложения](https://raw.githubusercontent.com/K1mer/Task_CS_RSSFeedReader/main/Screen1.png)

## Далее идёт исходное задание

Графическое приложение для чтения RSS ленты с сайта.
В файле настроек хранится:
Лента, которую обрабатывает фидер. По умолчанию это (https://habr.com/rss/interesting/).
Частота обновления ленты приложением.
Основное окно должно содержать список элементов ленты (item): 
Каждый элемент ленты должен отображать название и дату публикации (поля item->title и item->pubDate ). 
Дата публикации статьи должна отображаться в удобном для чтения пользователю формате.
При нажатии на заголовок должен открываться браузер с переходом на выбранную статью (или в уже открытом браузере должна открываться ссылка).
Пользователь должен иметь возможность посмотреть описание статьи 
(поле item->description). Содержание описание выводится в виде обычного текста (как есть), без форматирования по тегам.
Данные должны периодически обновляться. Частота обновления должна быть взята из файла конфигурации.
Пункты со звездочкой являются дополнительными и не обязательны для выполнения.

  *Файл настроек имеет формат XML.
  
  *Имеется возможность изменить ленту в меню настроек.
  
  *Имеется возможность изменить частоту обновления в меню настроек.
  
  *Опции в меню настроек валидируются.
  
  *Имеется возможность включить несколько лент. Пользователь должен иметь возможность включать и выключать ленты в окне приложения.
  
  *Выводить описание в виде, форматированном по тегам.
  
  *Иметь возможность переключения отображения описания в форматированном виде и без форматирования.
