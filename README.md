# Resolution-check

## About

Программа используется для проверки спрайтов на кратность 4. Для быстрого нахождения отклонений и корректной работы сжатия в проекте. При обнаружении отклонений, программа выделяет файл в списке.

Одновременно проверяются спрайты деревни и слот-машины одной эпохи.

Поддерживается только формат .png

## Download

Windows:

Mac OS:

## Installation

Содержимое архива поместить в папку с клиентом *“cm-client”*

![Screenshot 2023-01-20 at 23.37.25.png](Resolution-check%207a8f3ca663ea46abacaa6021b1cf5660/Screenshot_2023-01-20_at_23.37.25.png)

# Usage

После запуска программы и вывода сообщения, следует ввести название эпохи, так как оно указано в **Project View** Unity, с соблюдением регистра:

> Enter the Era name, like in the project view (e.g.: SteampunkVenice): LairOfCriminals
>

![Screenshot 2023-01-20 at 23.55.53.png](Resolution-check%207a8f3ca663ea46abacaa6021b1cf5660/Screenshot_2023-01-20_at_23.55.53.png)

Программа выведет список всех .png в два блока (отдельно для слот-машин и отдельно для деревень), с указанием разрешения изображения:

![Screenshot 2023-01-21 at 00.01.15.png](Resolution-check%207a8f3ca663ea46abacaa6021b1cf5660/Screenshot_2023-01-21_at_00.01.15.png)

Если разрешение одной из сторон не кратно 4, файл в списке будет выделен знаками *“-”*:

![Screenshot 2023-01-21 at 00.01.29.png](Resolution-check%207a8f3ca663ea46abacaa6021b1cf5660/Screenshot_2023-01-21_at_00.01.29.png)
