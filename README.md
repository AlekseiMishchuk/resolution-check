# Resolution-check

## About

Программа используется для проверки разрешения спрайтов на кратность четырём. Для быстрого нахождения отклонений и корректной работы сжатия в проекте. При обнаружении отклонений, программа выделяет файл в списке.

Одновременно проверяются спрайты деревни и слот-машины одной эпохи.

Работает только с форматом .png

## Download

**Windows**: [win-resolution-check.zip](https://github.com/AlexeyMischuk/resolution-check/releases/download/0.1/win-resolution-check.zip)

**Mac OS**: [macos-resolution-check.zip](https://github.com/AlexeyMischuk/resolution-check/releases/download/0.1/macos-resolution-check.zip)

## Installation

Содержимое архива поместить в папку с клиентом *“cm-client”*

  <img width="357" alt="Screenshot_2023-01-20_at_23 37 25" src="https://user-images.githubusercontent.com/93237623/213808145-00817441-eeff-49d1-9746-37a51b51bb16.png">



# Usage

- После запуска программы следует ввести название эпохи, так как оно указано в **Project View** Unity:

  > Enter the Era name, like in the project view (e.g.: SteampunkVenice): LairOfCriminals


  <img width="407" alt="Screenshot_2023-01-20_at_23 55 53" src="https://user-images.githubusercontent.com/93237623/213808153-6b744707-9ac1-49f8-a7ea-6ac600c78825.png">

- Программа выведет список всех .png в два блока (отдельно для слот-машин и отдельно для деревень), с указанием разрешения изображения:

  <img width="731" alt="Screenshot_2023-01-21_at_00 01 15" src="https://user-images.githubusercontent.com/93237623/213808155-1d804f60-7433-48c5-9240-819d719f8caf.png">

- Если разрешение одной из сторон не кратно 4, файл в списке будет выделен знаками *“-”*:

  <img width="720" alt="Screenshot_2023-01-21_at_00 01 29" src="https://user-images.githubusercontent.com/93237623/213808159-8feeead0-a694-4d4e-856f-15b8ba6b294b.png">

