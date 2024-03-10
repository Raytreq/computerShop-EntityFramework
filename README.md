# Computer Shop - CRUD
### This program creates automatically tables, using classes made in Model folder, then allows you to execute full CRUD on either Motherboards or Power Supply Units table.
While the image demonstrating the database's structure is in Polish, the program itself is written in English.     

## Database structure
![ProjektBazyDanych](https://github.com/Raytreq/computerShop-EntityFramework/assets/136091294/15edcf38-04dc-40e9-af77-652502eeb30c)
The database, as shown above, consists of 7 tables, that being:
* Computer, containing most of the other tables
* Disk
* CPU
* Motherboard
* RAM memory
* GPU
* PSU      
Each table has it's own ID and records representing it's different properties like for example CPU's socket or disk's model.     

## How to use it
<ol>
  <li> Copy this repository and open the program in Visual Studio</li>
  <li>  Make sure these two packages are properly installed:
    ![image](https://github.com/Raytreq/computerShop-EntityFramework/assets/136091294/67c81178-9381-4e57-a81a-d2c06bb24484)
  </li>
  <li> Run the program</li>
  <li> If you encounter any problems with a database, make sure that <a href="https://github.com/Raytreq/computerShop-EntityFramework/blob/main/krozmus_EF/ComputerShopContext.cs">context file</a> is configured correctly
    ![image](https://github.com/Raytreq/computerShop-EntityFramework/assets/136091294/676b70f1-db3e-42cd-bd24-43a88ea323ef)
  </li>
</ol>

## Teacher's instructions
### POL:
Wykonać aplikację korzystającą z bazy danych oraz Entity Framework.     
Należy:   
* utworzyć tabele w podejściu Code First
* baza ma zawierać co najmniej 4 tabele powiązane relacjami
* aplikacja ma mieć możliwość wykonania pełnego CRUDa dla dwóch wybranych tabel.
### ENG:
Make an application that uses a database and Entity Framework.    
* You should create tables with code-first approach
* The database needs to have at least 4 tables with made relations to each other
* The application must have full CRUD functionailty for two chosen tables     

## To do
- [x] Make sure that the database is being actually created correctly
- [ ] Add CRUD functionality to all tables
- [ ] Make English version of the image showing database's anatomy     

### If you come across any errors or bugs please let me know
![breaking-bad-meme-breaking-bad](https://github.com/Raytreq/computerShop-EntityFramework/assets/136091294/42915f39-be2b-496b-93b8-ce9858461ea9)

*Made in december 2023*
