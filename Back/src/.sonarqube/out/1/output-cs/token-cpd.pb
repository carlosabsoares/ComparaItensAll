ñ
qD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Commands\Category\CategoryDeleteCommand.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Commands &
{ 
public 

class !
CategoryDeleteCommand &
:' (

Notifiable) 3
,3 4
ICommand5 =
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public

 !
CategoryDeleteCommand

 $
(

$ %
)

% &
{ 	
} 	
public !
CategoryDeleteCommand $
($ %
int% (
id) +
)+ ,
{ 	
Id 
= 
id 
; 
} 	
public 
void 
Validate 
( 
) 
{ 	
AddNotifications 
( 
new 
Contract 
( 
) 
. 
Requires 
( 
) 
. 
IsGreaterThan "
(" #
Id# %
,% &
$num' (
,( )
$str* .
,. /
$str0 D
)D E
) 
; 
} 	
} 
} »
qD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Commands\Category\CategoryInsertCommand.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Commands &
{ 
public 

class !
CategoryInsertCommand &
:' (

Notifiable) 3
,3 4
ICommand5 =
{ 
public 
string 
Description !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
void 
Validate 
( 
) 
{ 	
AddNotifications 
( 
new 
Contract 
( 
) 
. 
Requires 
( 
) 
. 
IsNotNullOrEmpty %
(% &
Description& 1
,1 2
$str3 @
,@ A
$strB _
)_ `
) 
; 
} 	
} 
} Á
qD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Commands\Category\CategoryUpdateCommand.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Commands &
{ 
public 

class !
CategoryUpdateCommand &
:' (

Notifiable) 3
,3 4
ICommand5 =
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public		 
string		 
Description		 !
{		" #
get		$ '
;		' (
set		) ,
;		, -
}		. /
public !
CategoryUpdateCommand $
($ %
)% &
{ 	
} 	
public !
CategoryUpdateCommand $
($ %
int% (
id) +
,+ ,
string- 3
description4 ?
)? @
{ 	
Id 
= 
id 
; 
Description 
= 
description %
;% &
} 	
public 
void 
Validate 
( 
) 
{ 	
AddNotifications 
( 
new 
Contract 
( 
) 
. 
Requires 
( 
) 
. 
IsGreaterThan "
(" #
Id# %
,% &
$num' (
,( )
$str* .
,. /
$str0 D
)D E
. 
IsNotNullOrEmpty %
(% &
Description& 1
,1 2
$str3 @
,@ A
$strB _
)_ `
) 
; 
} 	
} 
} Ë

ìD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Commands\CharacteristicDescription\CharacteristicDescriptionDeleteCommand.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Commands &
{ 
public 

class 2
&CharacteristicDescriptionDeleteCommand 7
:8 9

Notifiable: D
,D E
ICommandF N
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public

 2
&CharacteristicDescriptionDeleteCommand

 5
(

5 6
int

6 9
id

: <
)

< =
{ 	
Id 
= 
id 
; 
} 	
public 
void 
Validate 
( 
) 
{ 	
AddNotifications 
( 
new 
Contract 
( 
) 
. 
Requires 
( 
) 
. 
IsGreaterThan "
(" #
Id# %
,% &
$num' (
,( )
$str* .
,. /
$str0 D
)D E
) 
; 
} 	
} 
} ë
ìD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Commands\CharacteristicDescription\CharacteristicDescriptionInsertCommand.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Commands &
{ 
public 

class 2
&CharacteristicDescriptionInsertCommand 7
:8 9

Notifiable: D
,D E
ICommandF N
{ 
public 
int 
CharacteristicId #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public		 
int		 
CharacteristicKeyId		 &
{		' (
get		) ,
;		, -
set		. 1
;		1 2
}		3 4
public 
void 
Validate 
( 
) 
{ 	
AddNotifications 
( 
new 
Contract 
( 
) 
. 
Requires 
( 
) 
. 
IsGreaterThan "
(" #
CharacteristicId# 3
,3 4
$num5 6
,6 7
$str8 J
,J K
$strL n
)n o
. 
IsGreaterThan "
(" #
CharacteristicKeyId# 6
,6 7
$num8 9
,9 :
$str; P
,P Q
$strR w
)w x
) 
; 
} 	
} 
} ﬂ
ìD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Commands\CharacteristicDescription\CharacteristicDescriptionUpdateCommand.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Commands &
{ 
public 

class 2
&CharacteristicDescriptionUpdateCommand 7
:8 9

Notifiable: D
,D E
ICommandF N
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public		 
int		 
CharacteristicId		 #
{		$ %
get		& )
;		) *
set		+ .
;		. /
}		0 1
public

 
int

 
CharacteristicKeyId

 &
{

' (
get

) ,
;

, -
set

. 1
;

1 2
}

3 4
public 
void 
Validate 
( 
) 
{ 	
AddNotifications 
( 
new 
Contract 
( 
) 
. 
Requires 
( 
) 
. 
IsGreaterThan "
(" #
Id# %
,% &
$num' (
,( )
$str* <
,< =
$str> `
)` a
. 
IsGreaterThan "
(" #
CharacteristicId# 3
,3 4
$num5 6
,6 7
$str8 J
,J K
$strL n
)n o
. 
IsGreaterThan "
(" #
CharacteristicKeyId# 6
,6 7
$num8 9
,9 :
$str; P
,P Q
$strR w
)w x
) 
; 
} 	
} 
} »

ÉD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Commands\CharacteristicKey\CharacteristicKeyDeleteCommand.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Commands &
{ 
public 

class *
CharacteristicKeyDeleteCommand /
:0 1

Notifiable2 <
,< =
ICommand> F
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public

 *
CharacteristicKeyDeleteCommand

 -
(

- .
int

. 1
id

2 4
)

4 5
{ 	
Id 
= 
id 
; 
} 	
public 
void 
Validate 
( 
) 
{ 	
AddNotifications 
( 
new 
Contract 
( 
) 
. 
Requires 
( 
) 
. 
IsGreaterThan "
(" #
Id# %
,% &
$num' (
,( )
$str* .
,. /
$str0 D
)D E
) 
; 
} 	
} 
} Œ
ÉD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Commands\CharacteristicKey\CharacteristicKeyInsertCommand.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Commands &
{ 
public 

class *
CharacteristicKeyInsertCommand /
:0 1

Notifiable2 <
,< =
ICommand> F
{ 
public		 
int		 
CharacteristicId		 #
{		$ %
get		& )
;		) *
set		+ .
;		. /
}		0 1
public

 
string

 
Description

 !
{

" #
get

$ '
;

' (
set

) ,
;

, -
}

. /
public 
void 
Validate 
( 
) 
{ 	
AddNotifications 
( 
new 
Contract 
( 
) 
. 
Requires 
( 
) 
. 
IsGreaterThan "
(" #
CharacteristicId# 3
,3 4
$num4 5
,5 6
$str7 <
,< =
$str> U
)U V
. 
IsNotNullOrEmpty %
(% &
Description& 1
,1 2
$str3 @
,@ A
$strB a
)a b
) 
; 
} 	
} 
} ú
ÉD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Commands\CharacteristicKey\CharacteristicKeyUpdateCommand.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Commands &
{ 
public 

class *
CharacteristicKeyUpdateCommand /
:0 1

Notifiable2 <
,< =
ICommand> F
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public		 
int		 
characteristicId		 #
{		$ %
get		& )
;		) *
set		+ .
;		. /
}		0 1
public

 
string

 
Description

 !
{

" #
get

$ '
;

' (
set

) ,
;

, -
}

. /
public 
void 
Validate 
( 
) 
{ 	
AddNotifications 
( 
new 
Contract 
( 
) 
. 
Requires 
( 
) 
. 
IsGreaterThan "
(" #
Id# %
,% &
$num' (
,( )
$str* .
,. /
$str0 D
)D E
. 
IsGreaterThan "
(" #
characteristicId# 3
,3 4
$num4 5
,5 6
$str7 I
,I J
$strK o
)o p
. 
IsNotNullOrEmpty %
(% &
Description& 1
,1 2
$str3 @
,@ A
$strB a
)a b
) 
; 
} 	
} 
} ⁄
}D:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Commands\Characteristic\CharacteristicDeleteCommand.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Commands &
{ 
public 

class '
CharacteristicDeleteCommand ,
:- .

Notifiable/ 9
,9 :
ICommand; C
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public		 
string		 
Description		 !
{		" #
get		$ '
;		' (
set		) ,
;		, -
}		. /
public '
CharacteristicDeleteCommand *
(* +
int+ .
id/ 1
)1 2
{ 	
Id 
= 
id 
; 
} 	
public 
void 
Validate 
( 
) 
{ 	
AddNotifications 
( 
new 
Contract 
( 
) 
. 
Requires 
( 
) 
. 
IsGreaterThan "
(" #
Id# %
,% &
$num' (
,( )
$str* .
,. /
$str0 D
)D E
) 
; 
} 	
} 
} ≠
}D:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Commands\Characteristic\CharacteristicInsertCommand.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Commands &
{ 
public 

class '
CharacteristicInsertCommand ,
:- .

Notifiable/ 9
,9 :
ICommand; C
{ 
public 
string 
Description !
{" #
get$ '
;' (
set) ,
;, -
}. /
public		 
int		 

CategoryId		 
{		 
get		  #
;		# $
set		% (
;		( )
}		* +
public '
CharacteristicInsertCommand *
(* +
)+ ,
{ 	
} 	
public '
CharacteristicInsertCommand *
(* +
string+ 1
description2 =
,= >
int? B

categoryIdC M
)M N
{ 	
Description 
= 
description %
;% &

CategoryId 
= 

categoryId #
;# $
} 	
public 
void 
Validate 
( 
) 
{ 	
AddNotifications 
( 
new 
Contract 
( 
) 
. 
Requires 
( 
) 
. 
IsGreaterThan "
(" #

CategoryId# -
,- .
$num/ 0
,0 1
$str2 >
,> ?
$str@ a
)a b
. 
IsNotNullOrEmpty %
(% &
Description& 1
,1 2
$str3 @
,@ A
$strB _
)_ `
) 
; 
} 	
} 
}   È
}D:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Commands\Characteristic\CharacteristicUpdateCommand.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Commands &
{ 
public 

class '
CharacteristicUpdateCommand ,
:- .

Notifiable/ 9
,9 :
ICommand; C
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public		 
string		 
Description		 !
{		" #
get		$ '
;		' (
set		) ,
;		, -
}		. /
public

 
int

 

CategoryId

 
{

 
get

  #
;

# $
set

% (
;

( )
}

* +
public '
CharacteristicUpdateCommand *
(* +
)+ ,
{ 	
} 	
public '
CharacteristicUpdateCommand *
(* +
int+ .
id/ 1
,1 2
string3 9
description: E
,E F
intG J

categoryIdK U
)U V
{ 	
Id 
= 
id 
; 
Description 
= 
description %
;% &

CategoryId 
= 

categoryId #
;# $
} 	
public 
void 
Validate 
( 
) 
{ 	
AddNotifications 
( 
new 
Contract 
( 
) 
. 
Requires 
( 
)  
. 
IsGreaterThan #
(# $
Id$ &
,& '
$num( )
,) *
$str+ /
,/ 0
$str1 E
)E F
. 
IsNotNullOrEmpty &
(& '
Description' 2
,2 3
$str4 A
,A B
$strC `
)` a
. 
IsGreaterThan #
(# $

CategoryId$ .
,. /
$num0 1
,1 2
$str3 ?
,? @
$strA b
)b c
) 
; 
}   	
}!! 
}"" ˇ
dD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Commands\Contract\ICommand.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Commands &
{ 
public 

	interface 
ICommand 
: 
IValidatable  ,
{ 
} 
} ˜
jD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Commands\Contract\ICommandResult.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Commands &
{ 
public 

	interface 
ICommandResult #
{ 
bool 
Success 
{ 
get 
; 
set 
;  
}! "
HttpStatusCode 
Code 
{ 
get !
;! "
set# &
;& '
}( )
object		 
Data		 
{		 
get		 
;		 
set		 
;		 
}		  !
}

 
} ¶
gD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Commands\GenericCommandResult.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Commands &
{ 
public 

class  
GenericCommandResult %
:& '
ICommandResult( 6
{ 
public  
GenericCommandResult #
(# $
)$ %
{ 	
}		 	
public  
GenericCommandResult #
(# $
bool$ (
success) 0
,0 1
HttpStatusCode2 @
codeA E
,E F
objectG M
dataN R
)R S
{ 	
Success 
= 
success 
; 
Code 
= 
code 
; 
Data 
= 
data 
; 
} 	
public 
bool 
Success 
{ 
get !
;! "
set# &
;& '
}( )
public 
HttpStatusCode 
Code "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
object 
Data 
{ 
get  
;  !
set" %
;% &
}' (
} 
} ™
yD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Commands\Manufacturer\ManufacturerDeleteCommand.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Commands &
{ 
public 

class %
ManufacturerDeleteCommand *
:+ ,

Notifiable- 7
,7 8
ICommand9 A
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public

 %
ManufacturerDeleteCommand

 (
(

( )
)

) *
{ 	
} 	
public %
ManufacturerDeleteCommand (
(( )
int) ,
id- /
)/ 0
{ 	
Id 
= 
id 
; 
} 	
public 
void 
Validate 
( 
) 
{ 	
AddNotifications 
( 
new 
Contract 
( 
) 
. 
Requires 
( 
) 
. 
IsGreaterThan "
(" #
Id# %
,% &
$num' (
,( )
$str* .
,. /
$str0 D
)D E
) 
; 
} 	
} 
} Ω
yD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Commands\Manufacturer\ManufacturerInsertCommand.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Commands &
{ 
public 

class %
ManufacturerInsertCommand *
:+ ,

Notifiable- 7
,7 8
ICommand9 A
{ 
public 
string 
Description !
{" #
get$ '
;' (
set) ,
;, -
}. /
public

 %
ManufacturerInsertCommand

 (
(

( )
)

) *
{ 	
} 	
public %
ManufacturerInsertCommand (
(( )
string) /

desciption0 :
): ;
{ 	
Description 
= 

desciption $
;$ %
} 	
public 
void 
Validate 
( 
) 
{ 	
AddNotifications 
( 
new 
Contract 
( 
) 
. 
Requires 
( 
) 
. 
IsNotNullOrEmpty %
(% &
Description& 1
,1 2
$str3 @
,@ A
$strB _
)_ `
) 
; 
} 	
} 
} ˚
yD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Commands\Manufacturer\ManufacturerUpdateCommand.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Commands &
{ 
public 

class %
ManufacturerUpdateCommand *
:+ ,

Notifiable- 7
,7 8
ICommand9 A
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public		 
string		 
Description		 !
{		" #
get		$ '
;		' (
set		) ,
;		, -
}		. /
public %
ManufacturerUpdateCommand (
(( )
)) *
{ 	
} 	
public %
ManufacturerUpdateCommand (
(( )
int) ,
id- /
,/ 0
string1 7
description8 C
)C D
{ 	
Id 
= 
id 
; 
Description 
= 
description %
;% &
} 	
public 
void 
Validate 
( 
) 
{ 	
AddNotifications 
( 
new 
Contract 
( 
) 
. 
Requires 
( 
) 
. 
IsGreaterThan "
(" #
Id# %
,% &
$num' (
,( )
$str* .
,. /
$str0 D
)D E
. 
IsNotNullOrEmpty %
(% &
Description& 1
,1 2
$str3 @
,@ A
$strB _
)_ `
) 
; 
} 	
} 
} ë
oD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Commands\Product\ProductDeleteCommand.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Commands &
{ 
public 

class  
ProductDeleteCommand %
:& '

Notifiable( 2
,2 3
ICommand4 <
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public

  
ProductDeleteCommand

 #
(

# $
)

$ %
{ 	
} 	
public  
ProductDeleteCommand #
(# $
int$ '
id( *
)* +
{ 	
Id 
= 
id 
; 
} 	
public 
void 
Validate 
( 
) 
{ 	
AddNotifications 
( 
new 
Contract 
( 
) 
. 
Requires 
( 
) 
. 
IsGreaterThan "
(" #
Id# %
,% &
$num' (
,( )
$str* .
,. /
$str0 D
)D E
) 
; 
} 	
} 
} À
oD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Commands\Product\ProductInsertCommand.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Commands &
{ 
public		 

class		  
ProductInsertCommand		 %
:		& '

Notifiable		( 2
,		2 3
ICommand		4 <
{

 
public 
string 
Description !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
string 
Model 
{ 
get !
;! "
set# &
;& '
}( )
public 
int 

CategoryId 
{ 
get  #
;# $
set% (
;( )
}* +
public 
int 
ManufacturerId !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
int 
YearOfManufacture $
{% &
get' *
;* +
set, /
;/ 0
}1 2
public 
	IFormFile 
Image 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
	IFormFile 
Folder 
{  !
get" %
;% &
set' *
;* +
}, -
public 
IList 
< %
CharacteristicDescription .
>. /&
CharacteristicDescriptions0 J
{K L
getM P
;P Q
setR U
;U V
}W X
public  
ProductInsertCommand #
(# $
)$ %
{ 	
} 	
public 
void 
Validate 
( 
) 
{   	
AddNotifications!! 
(!! 
new"" 
Contract"" 
("" 
)"" 
.## 
Requires## 
(## 
)## 
.$$ 
IsNotNullOrEmpty$$ %
($$% &
Description$$& 1
,$$1 2
$str$$3 @
,$$@ A
$str$$B _
)$$_ `
.%% 
IsNotNullOrEmpty%% %
(%%% &
Model%%& +
,%%+ ,
$str%%- 4
,%%4 5
$str%%6 O
)%%O P
.&& 
IsGreaterThan&& "
(&&" #

CategoryId&&# -
,&&- .
$num&&/ 0
,&&0 1
$str&&2 >
,&&> ?
$str&&@ \
)&&\ ]
.'' 
IsGreaterThan'' "
(''" #
ManufacturerId''# 1
,''1 2
$num''3 4
,''4 5
$str''6 F
,''F G
$str''H h
)''h i
.(( 
IsGreaterThan(( "
(((" #
YearOfManufacture((# 4
,((4 5
$num((6 7
,((7 8
$str((9 L
,((L M
$str((N q
)((q r
)++ 
;++ 
},, 	
}-- 
}.. í
oD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Commands\Product\ProductUpdateCommand.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Commands &
.& '
Product' .
{ 
public 

class  
ProductUpdateCommand %
:& '

Notifiable( 2
,2 3
ICommand4 <
{		 
public

 
int

 
Id

 
{

 
get

 
;

 
set

  
;

  !
}

" #
public 
string 
Description !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
string 
Model 
{ 
get !
;! "
set# &
;& '
}( )
public 
int 

CategoryId 
{ 
get  #
;# $
set% (
;( )
}* +
public 
int 
ManufacturerId !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
int 
YearOfManufacture $
{% &
get' *
;* +
set, /
;/ 0
}1 2
public 
IList 
< %
CharacteristicDescription .
>. /&
CharacteristicDescriptions0 J
{K L
getM P
;P Q
setR U
;U V
}W X
public 
void 
Validate 
( 
) 
{ 	
AddNotifications 
( 
new 
Contract 
( 
) 
. 
Requires 
( 
) 
. 
IsGreaterThan "
(" #
Id# %
,% &
$num' (
,( )
$str* .
,. /
$str0 D
)D E
. 
IsNotNullOrEmpty %
(% &
Description& 1
,1 2
$str3 @
,@ A
$strB _
)_ `
. 
IsNotNullOrEmpty %
(% &
Model& +
,+ ,
$str- 4
,4 5
$str6 O
)O P
. 
IsGreaterThan "
(" #

CategoryId# -
,- .
$num/ 0
,0 1
$str2 >
,> ?
$str@ \
)\ ]
. 
IsGreaterThan "
(" #
ManufacturerId# 1
,1 2
$num3 4
,4 5
$str6 F
,F G
$strH h
)h i
. 
IsGreaterThan "
(" #
YearOfManufacture# 4
,4 5
$num6 7
,7 8
$str9 L
,L M
$strN q
)q r
)"" 
;"" 
}## 	
}$$ 
}%% Ç
iD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Commands\User\UserDeleteCommand.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Commands &
{ 
public 

class 
UserDeleteCommand "
:# $

Notifiable% /
,/ 0
ICommand1 9
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public

 
UserDeleteCommand

  
(

  !
)

! "
{ 	
} 	
public 
UserDeleteCommand  
(  !
int! $
id% '
)' (
{ 	
Id 
= 
id 
; 
} 	
public 
void 
Validate 
( 
) 
{ 	
AddNotifications 
( 
new 
Contract 
( 
) 
. 
Requires 
( 
) 
. 
IsGreaterThan "
(" #
Id# %
,% &
$num' (
,( )
$str* .
,. /
$str0 D
)D E
) 
; 
} 	
} 
} ˜
iD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Commands\User\UserInsertCommand.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Commands &
{ 
public 

class 
UserInsertCommand "
:# $

Notifiable% /
,/ 0
ICommand1 9
{ 
public 
string 
Login 
{ 
get !
;! "
set# &
;& '
}( )
public		 
string		 
Password		 
{		  
get		! $
;		$ %
set		& )
;		) *
}		+ ,
public

 
string

 
Role

 
{

 
get

  
;

  !
set

" %
;

% &
}

' (
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public 
string 
Email 
{ 
get !
;! "
set# &
;& '
}( )
public 
void 
Validate 
( 
) 
{ 	
AddNotifications 
( 
new 
Contract 
( 
) 
. 
Requires 
( 
) 
. 
IsNotNullOrEmpty %
(% &
Login& +
,+ ,
$str- 4
,4 5
$str6 O
)O P
. 
IsNotNullOrEmpty %
(% &
Password& .
,. /
$str0 :
,: ;
$str< X
)X Y
. 
IsNotNullOrEmpty %
(% &
Name& *
,* +
$str, 2
,2 3
$str4 L
)L M
. 
IsNotNullOrEmpty %
(% &
Email& +
,+ ,
$str- 4
,4 5
$str6 O
)O P
) 
; 
} 	
} 
} È
iD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Commands\User\UserUpdateCommand.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Commands &
{ 
public 

class 
UserUpdateCommand "
:# $

Notifiable% /
,/ 0
ICommand1 9
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public		 
string		 
Password		 
{		  
get		! $
;		$ %
set		& )
;		) *
}		+ ,
public

 
string

 
Role

 
{

 
get

  
;

  !
set

" %
;

% &
}

' (
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public 
string 
Email 
{ 
get !
;! "
set# &
;& '
}( )
public 
void 
Validate 
( 
) 
{ 	
AddNotifications 
( 
new 
Contract 
( 
) 
. 
Requires 
( 
) 
. 
IsGreaterThan "
(" #
Id# %
,% &
$num' (
,( )
$str* .
,. /
$str0 D
)D E
. 
IsNotNullOrEmpty %
(% &
Name& *
,* +
$str, 2
,2 3
$str4 L
)L M
. 
IsNotNullOrEmpty %
(% &
Email& +
,+ ,
$str- 4
,4 5
$str6 O
)O P
) 
; 
} 	
} 
} ˇ

qD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Commands\User\UserValidateAccessCommand.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Commands &
{ 
public 

class %
UserValidateAccessCommand *
:+ ,

Notifiable- 7
,7 8
ICommand9 A
{ 
public 
string 
Login 
{ 
get !
;! "
set# &
;& '
}( )
public		 
string		 
Password		 
{		  
get		! $
;		$ %
set		& )
;		) *
}		+ ,
public 
void 
Validate 
( 
) 
{ 	
AddNotifications 
( 
new 
Contract 
( 
) 
. 
Requires 
( 
) 
. 
IsNotNullOrEmpty %
(% &
Login& +
,+ ,
$str- 4
,4 5
$str6 O
)O P
. 
IsNotNullOrEmpty %
(% &
Password& .
,. /
$str0 :
,: ;
$str< X
)X Y
) 
; 
} 	
} 
} ˚
[D:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Entities\Category.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Entities &
{ 
public 

class 
Category 
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
Description !
{" #
get$ '
;' (
set) ,
;, -
}. /
} 
} ı
aD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Entities\Characteristic.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Entities &
{ 
public 

class 
Characteristic 
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
Description !
{" #
get$ '
;' (
set) ,
;, -
}. /
public

 
int

 

CategoryId

 
{

 
get

  #
;

# $
set

% (
;

( )
}

* +
[ 	
	NotMapped	 
] 
public 
Category 
Category  
{! "
get# &
;& '
set( +
;+ ,
}- .
} 
} £
lD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Entities\CharacteristicDescription.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Entities &
{ 
public 

class %
CharacteristicDescription *
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public		 
int		 
	ProductId		 
{		 
get		 "
;		" #
set		$ '
;		' (
}		) *
public 
int 
CharacteristicId #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	
	NotMapped	 
] 
public 
Characteristic 
Characteristics -
{. /
get0 3
;3 4
set5 8
;8 9
}: ;
public 
int 
CharacteristicKeyId &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
[ 	
	NotMapped	 
] 
public 
CharacteristicKey  
CharacteristicKeys! 3
{4 5
get6 9
;9 :
set; >
;> ?
}@ A
} 
} é
dD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Entities\CharacteristicKey.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Entities &
{ 
public 

class 
CharacteristicKey "
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public

 
string

 
Description

 !
{

" #
get

$ '
;

' (
set

) ,
;

, -
}

. /
public 
int 
CharacteristicId #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	
	NotMapped	 
] 
public 
Characteristic 
Characteristics -
{. /
get0 3
;3 4
set5 8
;8 9
}: ;
} 
} Ì
YD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Entities\Entity.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Entities &
{ 
public 

abstract 
class 
Entity  
{ 
public 
Guid 
Id 
{ 
get 
; 
private %
set& )
;) *
}+ ,
	protected		 
Entity		 
(		 
)		 
{

 	
Id 
= 
Guid 
. 
NewGuid 
( 
) 
;  
} 	
} 
} Ë
`D:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Entities\Enum\enumRole.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Entities &
{ 
public 

enum 
enumRole 
{ 
Administrator 
} 
} —
_D:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Entities\ItensProduct.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Entities &
{ 
public 

class 
ItensProduct 
{ 
} 
} Ú
_D:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Entities\Manufacturer.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Entities &
{ 
public 

class 
Manufacturer 
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
Description !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
Manufacturer 
( 
) 
{		 	
}

 	
public 
Manufacturer 
( 
int 
id  "
," #
string$ *
description+ 6
)6 7
{ 	
Id 
= 
id 
; 
Description 
= 
description %
;% &
} 	
public 
Manufacturer 
( 
string "
description# .
). /
{ 	
Description 
= 
description %
;% &
} 	
public 
Manufacturer 
( 
int 
id  "
)" #
{ 	
Id 
= 
id 
; 
} 	
} 
} Ù
ZD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Entities\Product.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Entities &
{ 
public 

class 
Product 
{ 
public		 
int		 
Id		 
{		 
get		 
;		 
set		  
;		  !
}		" #
public 
string 
Description !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
int 
ManufacturerId !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
string 
Model 
{ 
get !
;! "
set# &
;& '
}( )
public 
int 

CategoryId 
{ 
get  #
;# $
set% (
;( )
}* +
[ 	
Range	 
( 
$num 
, 
$num 
, 
ErrorMessage '
=( )
$str* ;
); <
]< =
public 
int 
YearOfManufacture $
{% &
get' *
;* +
set, /
;/ 0
}1 2
[ 	
	NotMapped	 
] 
public 
Manufacturer 
Manufecturer (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
[ 	
	NotMapped	 
] 
public 
Category 
Category  
{! "
get# &
;& '
set( +
;+ ,
}- .
[   	
	NotMapped  	 
]   
public!! 
IList!! 
<!! %
CharacteristicDescription!! .
>!!. /&
CharacteristicDescriptions!!0 J
{!!K L
get!!M P
;!!P Q
set!!R U
;!!U V
}!!W X
public## 
Product## 
(## 
)## 
{$$ 	
}%% 	
}&& 
}'' “	
WD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Entities\User.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Entities &
{ 
public 

class 
User 
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
Login 
{ 
get !
;! "
set# &
;& '
}( )
public 
string 
Password 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public		 
string		 
Email		 
{		 
get		 !
;		! "
set		# &
;		& '
}		( )
public

 
string

 
Role

 
{

 
get

  
;

  !
set

" %
;

% &
}

' (
} 
} Ó=
bD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Handlers\CategoryHandler.cs
	namespace		 	
ComparaItens		
 
.		 
Domain		 
.		 
Handlers		 &
{

 
public 

class 
CategoryHandler  
:! "

Notifiable 
, 
IHandler 
< !
CategoryInsertCommand *
>* +
,+ ,
IHandler 
< !
CategoryDeleteCommand *
>* +
,+ ,
IHandler 
< !
CategoryUpdateCommand *
>* +
{ 
private 
readonly 
ICudRepository '
_cudRepository( 6
;6 7
private 
readonly 
ICategoryRepository ,
_categoryRepository- @
;@ A
public 
CategoryHandler 
( 
ICudRepository -
cudRepository. ;
,; <
ICategoryRepository= P
categoryRepositoryQ c
)c d
{ 	
_cudRepository 
= 
cudRepository *
;* +
_categoryRepository 
=  !
categoryRepository" 4
;4 5
} 	
public 
async 
Task 
< 
ICommandResult (
>( )
Handle* 0
(0 1!
CategoryInsertCommand1 F
commandG N
)N O
{ 	
command 
. 
Validate 
( 
) 
; 
if 
( 
command 
. 
Invalid 
)  
return 
new  
GenericCommandResult /
(/ 0
false   !
,  ! "
HttpStatusCode!! *
.!!* +

BadRequest!!+ 5
,!!5 6
command"" #
.""# $
Notifications""$ 1
)""1 2
;""2 3
var$$ 
_entity$$ 
=$$ 
new$$ 
Category$$ &
{%% 
Description&& 
=&& 
command&& %
.&&% &
Description&&& 1
}'' 
;'' 
var)) 
_result)) 
=)) 
await)) 
_cudRepository))  .
.)). /
Add))/ 2
())2 3
_entity))3 :
))): ;
;)); <
if,, 
(,, 
!,, 
_result,, 
),, 
return-- 
new--  
GenericCommandResult-- /
(--/ 0
false--0 5
,--5 6
HttpStatusCode--7 E
.--E F

BadRequest--F P
,--P Q
_result--R Y
)--Y Z
;--Z [
return// 
new//  
GenericCommandResult// +
(//+ ,
true//, 0
,//0 1
HttpStatusCode//2 @
.//@ A
Created//A H
,//H I
_result//J Q
)//Q R
;//R S
}00 	
public22 
async22 
Task22 
<22 
ICommandResult22 (
>22( )
Handle22* 0
(220 1!
CategoryDeleteCommand221 F
command22G N
)22N O
{33 	
command55 
.55 
Validate55 
(55 
)55 
;55 
if66 
(66 
command66 
.66 
Invalid66 
)66  
return77 
new77  
GenericCommandResult77 /
(77/ 0
false88 !
,88! "
HttpStatusCode99 *
.99* +

BadRequest99+ 5
,995 6
command:: #
.::# $
Notifications::$ 1
)::1 2
;::2 3
var<< 
_verify<< 
=<< 
await<< 
_categoryRepository<<  3
.<<3 4
FindById<<4 <
(<<< =
command<<= D
.<<D E
Id<<E G
)<<G H
;<<H I
if>> 
(>> 
_verify>> 
==>> 
null>> 
)>>  
return?? 
new??  
GenericCommandResult?? /
(??/ 0
false??0 5
,??5 6
HttpStatusCode??7 E
.??E F
NotFound??F N
,??N O
$str??P h
)??h i
;??i j
varAA 
_entityAA 
=AA 
newAA 
CategoryAA &
{BB 
IdCC 
=CC 
commandCC 
.CC 
IdCC 
}DD 
;DD 
varFF 
_resultFF 
=FF 
awaitFF 
_cudRepositoryFF  .
.FF. /
DeleteFF/ 5
(FF5 6
_entityFF6 =
)FF= >
;FF> ?
ifII 
(II 
!II 
_resultII 
)II 
returnJJ 
newJJ  
GenericCommandResultJJ /
(JJ/ 0
falseJJ0 5
,JJ5 6
HttpStatusCodeJJ7 E
.JJE F

BadRequestJJF P
,JJP Q
_resultJJR Y
)JJY Z
;JJZ [
returnLL 
newLL  
GenericCommandResultLL +
(LL+ ,
trueLL, 0
,LL0 1
HttpStatusCodeLL2 @
.LL@ A
OKLLA C
,LLC D
_resultLLE L
)LLL M
;LLM N
}MM 	
publicOO 
asyncOO 
TaskOO 
<OO 
ICommandResultOO (
>OO( )
HandleOO* 0
(OO0 1!
CategoryUpdateCommandOO1 F
commandOOG N
)OON O
{PP 	
commandRR 
.RR 
ValidateRR 
(RR 
)RR 
;RR 
ifSS 
(SS 
commandSS 
.SS 
InvalidSS 
)SS  
returnTT 
newTT  
GenericCommandResultTT /
(TT/ 0
falseUU !
,UU! "
HttpStatusCodeVV *
.VV* +

BadRequestVV+ 5
,VV5 6
commandWW #
.WW# $
NotificationsWW$ 1
)WW1 2
;WW2 3
varYY 
_verifyYY 
=YY 
awaitYY 
_categoryRepositoryYY  3
.YY3 4
FindByIdYY4 <
(YY< =
commandYY= D
.YYD E
IdYYE G
)YYG H
;YYH I
if[[ 
([[ 
_verify[[ 
==[[ 
null[[ 
)[[  
return\\ 
new\\  
GenericCommandResult\\ /
(\\/ 0
false\\0 5
,\\5 6
HttpStatusCode\\7 E
.\\E F
NotFound\\F N
,\\N O
$str\\P h
)\\h i
;\\i j
var^^ 
_entity^^ 
=^^ 
new^^ 
Category^^ &
{__ 
Id`` 
=`` 
command`` 
.`` 
Id`` 
,``  
Descriptionaa 
=aa 
commandaa %
.aa% &
Descriptionaa& 1
}bb 
;bb 
vardd 
_resultdd 
=dd 
awaitdd 
_cudRepositorydd  .
.dd. /
Updatedd/ 5
(dd5 6
_entitydd6 =
)dd= >
;dd> ?
ifgg 
(gg 
!gg 
_resultgg 
)gg 
returnhh 
newhh  
GenericCommandResulthh /
(hh/ 0
falsehh0 5
,hh5 6
HttpStatusCodehh7 E
.hhE F

BadRequesthhF P
,hhP Q
_resulthhR Y
)hhY Z
;hhZ [
returnjj 
newjj  
GenericCommandResultjj +
(jj+ ,
truejj, 0
,jj0 1
HttpStatusCodejj2 @
.jj@ A
OKjjA C
,jjC D
_resultjjE L
)jjL M
;jjM N
}kk 	
}ll 
}mm ·B
sD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Handlers\CharacteristicDescriptionHandler.cs
	namespace		 	
ComparaItens		
 
.		 
Domain		 
.		 
Handlers		 &
{

 
public 

class ,
 CharacteristicDescriptionHandler 1
:2 3

Notifiable4 >
,> ?
IHandler 
< 2
&CharacteristicDescriptionInsertCommand ;
>; <
,< =
IHandler 
< 2
&CharacteristicDescriptionDeleteCommand ;
>; <
,< =
IHandler 
< 2
&CharacteristicDescriptionUpdateCommand ;
>; <
{ 
private 
readonly 
ICudRepository '
_cudRepository( 6
;6 7
private 
readonly 0
$ICharacteristicDescriptionRepository =0
$_characteristicDescriptionRepository> b
;b c
public ,
 CharacteristicDescriptionHandler /
(/ 0
ICudRepository0 >
cudRepository? L
,L M0
$ICharacteristicDescriptionRepositoryN r0
#characteristicDescriptionRepository	s ñ
)
ñ ó
{ 	
_cudRepository 
= 
cudRepository *
;* +0
$_characteristicDescriptionRepository 0
=1 2/
#characteristicDescriptionRepository3 V
;V W
} 	
public 
async 
Task 
< 
ICommandResult (
>( )
Handle* 0
(0 12
&CharacteristicDescriptionInsertCommand1 W
commandX _
)_ `
{ 	
command 
. 
Validate 
( 
) 
; 
if 
( 
command 
. 
Invalid 
)  
return 
new  
GenericCommandResult /
(/ 0
false !
,! "
HttpStatusCode   *
.  * +

BadRequest  + 5
,  5 6
command!! #
.!!# $
Notifications!!$ 1
)!!1 2
;!!2 3
var## 
_entity## 
=## 
new## %
CharacteristicDescription## 7
{$$ 
CharacteristicId%%  
=%%! "
command%%# *
.%%* +
CharacteristicId%%+ ;
,%%; <
CharacteristicKeyId&& #
=&&$ %
command&&& -
.&&- .
CharacteristicKeyId&&. A
}'' 
;'' 
var)) 
_result)) 
=)) 
await)) 
_cudRepository))  .
.)). /
Add))/ 2
())2 3
_entity))3 :
))): ;
;)); <
if,, 
(,, 
!,, 
_result,, 
),, 
return-- 
new--  
GenericCommandResult-- /
(--/ 0
false--0 5
,--5 6
HttpStatusCode--7 E
.--E F

BadRequest--F P
,--P Q
_result--R Y
)--Y Z
;--Z [
return// 
new//  
GenericCommandResult// +
(//+ ,
true//, 0
,//0 1
HttpStatusCode//2 @
.//@ A
Created//A H
,//H I
_result//J Q
)//Q R
;//R S
}00 	
public22 
async22 
Task22 
<22 
ICommandResult22 (
>22( )
Handle22* 0
(220 12
&CharacteristicDescriptionDeleteCommand221 W
command22X _
)22_ `
{33 	
command55 
.55 
Validate55 
(55 
)55 
;55 
if66 
(66 
command66 
.66 
Invalid66 
)66  
return77 
new77  
GenericCommandResult77 /
(77/ 0
false88 !
,88! "
HttpStatusCode99 *
.99* +

BadRequest99+ 5
,995 6
command:: #
.::# $
Notifications::$ 1
)::1 2
;::2 3
var<< 
_verify<< 
=<< 
await<< 0
$_characteristicDescriptionRepository<<  D
.<<D E
FindById<<E M
(<<M N
command<<N U
.<<U V
Id<<V X
)<<X Y
;<<Y Z
if>> 
(>> 
_verify>> 
==>> 
null>> 
)>>  
return?? 
new??  
GenericCommandResult?? /
(??/ 0
false??0 5
,??5 6
HttpStatusCode??7 E
.??E F
NotFound??F N
,??N O
$str??P h
)??h i
;??i j
varAA 
_entityAA 
=AA 
newAA %
CharacteristicDescriptionAA 7
{BB 
IdCC 
=CC 
commandCC 
.CC 
IdCC 
}DD 
;DD 
varFF 
_resultFF 
=FF 
awaitFF 
_cudRepositoryFF  .
.FF. /
DeleteFF/ 5
(FF5 6
_entityFF6 =
)FF= >
;FF> ?
ifII 
(II 
!II 
_resultII 
)II 
returnJJ 
newJJ  
GenericCommandResultJJ /
(JJ/ 0
falseJJ0 5
,JJ5 6
HttpStatusCodeJJ7 E
.JJE F

BadRequestJJF P
,JJP Q
_resultJJR Y
)JJY Z
;JJZ [
returnLL 
newLL  
GenericCommandResultLL +
(LL+ ,
trueLL, 0
,LL0 1
HttpStatusCodeLL2 @
.LL@ A
OKLLA C
,LLC D
_resultLLE L
)LLL M
;LLM N
}MM 	
publicOO 
asyncOO 
TaskOO 
<OO 
ICommandResultOO (
>OO( )
HandleOO* 0
(OO0 12
&CharacteristicDescriptionUpdateCommandOO1 W
commandOOX _
)OO_ `
{PP 	
commandRR 
.RR 
ValidateRR 
(RR 
)RR 
;RR 
ifSS 
(SS 
commandSS 
.SS 
InvalidSS 
)SS  
returnTT 
newTT  
GenericCommandResultTT /
(TT/ 0
falseUU !
,UU! "
HttpStatusCodeVV *
.VV* +

BadRequestVV+ 5
,VV5 6
commandWW #
.WW# $
NotificationsWW$ 1
)WW1 2
;WW2 3
varYY 
_verifyYY 
=YY 
awaitYY 0
$_characteristicDescriptionRepositoryYY  D
.YYD E
FindByIdYYE M
(YYM N
commandYYN U
.YYU V
IdYYV X
)YYX Y
;YYY Z
if[[ 
([[ 
_verify[[ 
==[[ 
null[[ 
)[[  
return\\ 
new\\  
GenericCommandResult\\ /
(\\/ 0
false\\0 5
,\\5 6
HttpStatusCode\\7 E
.\\E F
NotFound\\F N
,\\N O
$str\\P h
)\\h i
;\\i j
var^^ 
_entity^^ 
=^^ 
new^^ %
CharacteristicDescription^^ 7
{__ 
Id`` 
=`` 
command`` 
.`` 
Id`` 
,``  
CharacteristicIdaa  
=aa! "
commandaa# *
.aa* +
CharacteristicIdaa+ ;
,aa; <
CharacteristicKeyIdbb #
=bb$ %
commandbb& -
.bb- .
CharacteristicKeyIdbb. A
}cc 
;cc 
varee 
_resultee 
=ee 
awaitee 
_cudRepositoryee  .
.ee. /
Deleteee/ 5
(ee5 6
_entityee6 =
)ee= >
;ee> ?
ifhh 
(hh 
!hh 
_resulthh 
)hh 
returnii 
newii  
GenericCommandResultii /
(ii/ 0
falseii0 5
,ii5 6
HttpStatusCodeii7 E
.iiE F

BadRequestiiF P
,iiP Q
_resultiiR Y
)iiY Z
;iiZ [
returnkk 
newkk  
GenericCommandResultkk +
(kk+ ,
truekk, 0
,kk0 1
HttpStatusCodekk2 @
.kk@ A
OKkkA C
,kkC D
_resultkkE L
)kkL M
;kkM N
}ll 	
}mm 
}nn B
hD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Handlers\CharacteristicHandler.cs
	namespace		 	
ComparaItens		
 
.		 
Domain		 
.		 
Handlers		 &
{

 
public 

class !
CharacteristicHandler &
:' (

Notifiable) 3
,3 4
IHandler 
< '
CharacteristicInsertCommand 0
>0 1
,1 2
IHandler 
< '
CharacteristicDeleteCommand 0
>0 1
,1 2
IHandler 
< '
CharacteristicUpdateCommand 0
>0 1
{ 
private 
readonly 
ICudRepository '
_cudRepository( 6
;6 7
private 
readonly %
ICharacteristicRepository 2%
_characteristicRepository3 L
;L M
public !
CharacteristicHandler $
($ %
ICudRepository% 3
cudRepository4 A
,A B%
ICharacteristicRepositoryC \$
characteristicRepository] u
)u v
{ 	
_cudRepository 
= 
cudRepository *
;* +%
_characteristicRepository %
=& '$
characteristicRepository( @
;@ A
} 	
public 
async 
Task 
< 
ICommandResult (
>( )
Handle* 0
(0 1'
CharacteristicInsertCommand1 L
commandM T
)T U
{ 	
command 
. 
Validate 
( 
) 
; 
if 
( 
command 
. 
Invalid 
)  
return 
new  
GenericCommandResult /
(/ 0
false !
,! "
HttpStatusCode   *
.  * +

BadRequest  + 5
,  5 6
command!! #
.!!# $
Notifications!!$ 1
)!!1 2
;!!2 3
Characteristic## 
_entity## "
=### $
new##% (
Characteristic##) 7
(##7 8
)##8 9
;##9 :
_entity$$ 
.$$ 
Description$$ 
=$$  !
command$$" )
.$$) *
Description$$* 5
;$$5 6
_entity%% 
.%% 

CategoryId%% 
=%%  
command%%! (
.%%( )

CategoryId%%) 3
;%%3 4
var'' 
_result'' 
='' 
await'' 
_cudRepository''  .
.''. /
Add''/ 2
(''2 3
_entity''3 :
)'': ;
;''; <
if** 
(** 
!** 
_result** 
)** 
return++ 
new++  
GenericCommandResult++ /
(++/ 0
false++0 5
,++5 6
HttpStatusCode++7 E
.++E F

BadRequest++F P
,++P Q
_result++R Y
)++Y Z
;++Z [
return-- 
new--  
GenericCommandResult-- +
(--+ ,
true--, 0
,--0 1
HttpStatusCode--2 @
.--@ A
Created--A H
,--H I
_result--J Q
)--Q R
;--R S
}.. 	
public00 
async00 
Task00 
<00 
ICommandResult00 (
>00( )
Handle00* 0
(000 1'
CharacteristicDeleteCommand001 L
command00M T
)00T U
{11 	
command33 
.33 
Validate33 
(33 
)33 
;33 
if44 
(44 
command44 
.44 
Invalid44 
)44  
return55 
new55  
GenericCommandResult55 /
(55/ 0
false66 !
,66! "
HttpStatusCode77 *
.77* +

BadRequest77+ 5
,775 6
command88 #
.88# $
Notifications88$ 1
)881 2
;882 3
var:: 
_verify:: 
=:: 
await:: %
_characteristicRepository::  9
.::9 :
FindById::: B
(::B C
command::C J
.::J K
Id::K M
)::M N
;::N O
if<< 
(<< 
_verify<< 
==<< 
null<< 
)<<  
return== 
new==  
GenericCommandResult== /
(==/ 0
false==0 5
,==5 6
HttpStatusCode==7 E
.==E F
NotFound==F N
,==N O
$str==P h
)==h i
;==i j
Characteristic?? 
_entity?? "
=??# $
new??% (
Characteristic??) 7
(??7 8
)??8 9
;??9 :
_entity@@ 
.@@ 
Id@@ 
=@@ 
command@@  
.@@  !
Id@@! #
;@@# $
varBB 
_resultBB 
=BB 
awaitBB 
_cudRepositoryBB  .
.BB. /
DeleteBB/ 5
(BB5 6
_entityBB6 =
)BB= >
;BB> ?
ifEE 
(EE 
!EE 
_resultEE 
)EE 
returnFF 
newFF  
GenericCommandResultFF /
(FF/ 0
falseFF0 5
,FF5 6
HttpStatusCodeFF7 E
.FFE F

BadRequestFFF P
,FFP Q
_resultFFR Y
)FFY Z
;FFZ [
returnHH 
newHH  
GenericCommandResultHH +
(HH+ ,
trueHH, 0
,HH0 1
HttpStatusCodeHH2 @
.HH@ A
OKHHA C
,HHC D
_resultHHE L
)HHL M
;HHM N
}II 	
publicKK 
asyncKK 
TaskKK 
<KK 
ICommandResultKK (
>KK( )
HandleKK* 0
(KK0 1'
CharacteristicUpdateCommandKK1 L
commandKKM T
)KKT U
{LL 	
commandNN 
.NN 
ValidateNN 
(NN 
)NN 
;NN 
ifOO 
(OO 
commandOO 
.OO 
InvalidOO 
)OO  
returnPP 
newPP  
GenericCommandResultPP /
(PP/ 0
falseQQ !
,QQ! "
HttpStatusCodeRR *
.RR* +

BadRequestRR+ 5
,RR5 6
commandSS #
.SS# $
NotificationsSS$ 1
)SS1 2
;SS2 3
varUU 
_verifyUU 
=UU 
awaitUU %
_characteristicRepositoryUU  9
.UU9 :
FindByIdUU: B
(UUB C
commandUUC J
.UUJ K
IdUUK M
)UUM N
;UUN O
ifWW 
(WW 
_verifyWW 
==WW 
nullWW 
)WW  
returnXX 
newXX  
GenericCommandResultXX /
(XX/ 0
falseXX0 5
,XX5 6
HttpStatusCodeXX7 E
.XXE F
NotFoundXXF N
,XXN O
$strXXP h
)XXh i
;XXi j
CharacteristicZZ 
_entityZZ "
=ZZ# $
newZZ% (
CharacteristicZZ) 7
(ZZ7 8
)ZZ8 9
;ZZ9 :
_entity[[ 
.[[ 
Id[[ 
=[[ 
command[[  
.[[  !
Id[[! #
;[[# $
_entity\\ 
.\\ 
Description\\ 
=\\  !
command\\" )
.\\) *
Description\\* 5
;\\5 6
_entity]] 
.]] 

CategoryId]] 
=]]  
command]]! (
.]]( )

CategoryId]]) 3
;]]3 4
var__ 
_result__ 
=__ 
await__ 
_cudRepository__  .
.__. /
Update__/ 5
(__5 6
_entity__6 =
)__= >
;__> ?
ifbb 
(bb 
!bb 
_resultbb 
)bb 
returncc 
newcc  
GenericCommandResultcc /
(cc/ 0
falsecc0 5
,cc5 6
HttpStatusCodecc7 E
.ccE F

BadRequestccF P
,ccP Q
_resultccR Y
)ccY Z
;ccZ [
returnee 
newee  
GenericCommandResultee +
(ee+ ,
trueee, 0
,ee0 1
HttpStatusCodeee2 @
.ee@ A
OKeeA C
,eeC D
_resulteeE L
)eeL M
;eeM N
}ff 	
}gg 
}hh ûA
kD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Handlers\CharacteristicKeyHandler.cs
	namespace		 	
ComparaItens		
 
.		 
Domain		 
.		 
Handlers		 &
{

 
public 

class $
CharacteristicKeyHandler )
:* +

Notifiable, 6
,6 7
IHandler 
< *
CharacteristicKeyInsertCommand 3
>3 4
,4 5
IHandler 
< *
CharacteristicKeyDeleteCommand 3
>3 4
,4 5
IHandler 
< *
CharacteristicKeyUpdateCommand 3
>3 4
{ 
private 
readonly 
ICudRepository '
_cudRepository( 6
;6 7
private 
readonly (
ICharacteristicKeyRepository 5(
_characteristicKeyRepository6 R
;R S
public $
CharacteristicKeyHandler '
(' (
ICudRepository( 6
cudRepository7 D
,D E(
ICharacteristicKeyRepositoryF b'
characteristicKeyRepositoryc ~
)~ 
{ 	
_cudRepository 
= 
cudRepository *
;* +(
_characteristicKeyRepository (
=) *'
characteristicKeyRepository+ F
;F G
} 	
public 
async 
Task 
< 
ICommandResult (
>( )
Handle* 0
(0 1*
CharacteristicKeyInsertCommand1 O
commandP W
)W X
{ 	
command 
. 
Validate 
( 
) 
; 
if 
( 
command 
. 
Invalid 
)  
return 
new  
GenericCommandResult /
(/ 0
false !
,! "
HttpStatusCode   *
.  * +

BadRequest  + 5
,  5 6
command!! #
.!!# $
Notifications!!$ 1
)!!1 2
;!!2 3
var## 
_entity## 
=## 
new## 
CharacteristicKey## /
{$$ 
CharacteristicId%%  
=%%! "
command%%# *
.%%* +
CharacteristicId%%+ ;
,%%; <
Description&& 
=&& 
command&& %
.&&% &
Description&&& 1
}'' 
;'' 
var)) 
_result)) 
=)) 
await)) 
_cudRepository))  .
.)). /
Add))/ 2
())2 3
_entity))3 :
))): ;
;)); <
if,, 
(,, 
!,, 
_result,, 
),, 
return-- 
new--  
GenericCommandResult-- /
(--/ 0
false--0 5
,--5 6
HttpStatusCode--7 E
.--E F

BadRequest--F P
,--P Q
_result--R Y
)--Y Z
;--Z [
return// 
new//  
GenericCommandResult// +
(//+ ,
true//, 0
,//0 1
HttpStatusCode//2 @
.//@ A
Created//A H
,//H I
_result//J Q
)//Q R
;//R S
}00 	
public22 
async22 
Task22 
<22 
ICommandResult22 (
>22( )
Handle22* 0
(220 1*
CharacteristicKeyUpdateCommand221 O
command22P W
)22W X
{33 	
command55 
.55 
Validate55 
(55 
)55 
;55 
if66 
(66 
command66 
.66 
Invalid66 
)66  
return77 
new77  
GenericCommandResult77 /
(77/ 0
false88 !
,88! "
HttpStatusCode99 *
.99* +

BadRequest99+ 5
,995 6
command:: #
.::# $
Notifications::$ 1
)::1 2
;::2 3
var<< 
_verify<< 
=<< 
await<< (
_characteristicKeyRepository<<  <
.<<< =
FindById<<= E
(<<E F
command<<F M
.<<M N
Id<<N P
)<<P Q
;<<Q R
if>> 
(>> 
_verify>> 
==>> 
null>> 
)>>  
return?? 
new??  
GenericCommandResult?? /
(??/ 0
false??0 5
,??5 6
HttpStatusCode??7 E
.??E F
NotFound??F N
,??N O
$str??P h
)??h i
;??i j
varAA 
_entityAA 
=AA 
newAA 
CharacteristicKeyAA /
{BB 
IdCC 
=CC 
commandCC 
.CC 
IdCC 
,CC  
CharacteristicIdDD  
=DD! "
commandDD# *
.DD* +
characteristicIdDD+ ;
,DD; <
DescriptionEE 
=EE 
commandEE %
.EE% &
DescriptionEE& 1
}FF 
;FF 
varHH 
_resultHH 
=HH 
awaitHH 
_cudRepositoryHH  .
.HH. /
UpdateHH/ 5
(HH5 6
_entityHH6 =
)HH= >
;HH> ?
ifKK 
(KK 
!KK 
_resultKK 
)KK 
returnLL 
newLL  
GenericCommandResultLL /
(LL/ 0
falseLL0 5
,LL5 6
HttpStatusCodeLL7 E
.LLE F

BadRequestLLF P
,LLP Q
_resultLLR Y
)LLY Z
;LLZ [
returnNN 
newNN  
GenericCommandResultNN +
(NN+ ,
trueNN, 0
,NN0 1
HttpStatusCodeNN2 @
.NN@ A
OKNNA C
,NNC D
_resultNNE L
)NNL M
;NNM N
}OO 	
publicQQ 
asyncQQ 
TaskQQ 
<QQ 
ICommandResultQQ (
>QQ( )
HandleQQ* 0
(QQ0 1*
CharacteristicKeyDeleteCommandQQ1 O
commandQQP W
)QQW X
{RR 	
commandTT 
.TT 
ValidateTT 
(TT 
)TT 
;TT 
ifUU 
(UU 
commandUU 
.UU 
InvalidUU 
)UU  
returnVV 
newVV  
GenericCommandResultVV /
(VV/ 0
falseWW !
,WW! "
HttpStatusCodeXX *
.XX* +

BadRequestXX+ 5
,XX5 6
commandYY #
.YY# $
NotificationsYY$ 1
)YY1 2
;YY2 3
var[[ 
_verify[[ 
=[[ 
await[[ (
_characteristicKeyRepository[[  <
.[[< =
FindById[[= E
([[E F
command[[F M
.[[M N
Id[[N P
)[[P Q
;[[Q R
if]] 
(]] 
_verify]] 
==]] 
null]] 
)]]  
return^^ 
new^^  
GenericCommandResult^^ /
(^^/ 0
false^^0 5
,^^5 6
HttpStatusCode^^7 E
.^^E F
NotFound^^F N
,^^N O
$str^^P h
)^^h i
;^^i j
var`` 
_entity`` 
=`` 
new`` 
CharacteristicKey`` /
{aa 
Idbb 
=bb 
commandbb 
.bb 
Idbb 
}cc 
;cc 
varee 
_resultee 
=ee 
awaitee 
_cudRepositoryee  .
.ee. /
Deleteee/ 5
(ee5 6
_entityee6 =
)ee= >
;ee> ?
ifhh 
(hh 
!hh 
_resulthh 
)hh 
returnii 
newii  
GenericCommandResultii /
(ii/ 0
falseii0 5
,ii5 6
HttpStatusCodeii7 E
.iiE F

BadRequestiiF P
,iiP Q
_resultiiR Y
)iiY Z
;iiZ [
returnkk 
newkk  
GenericCommandResultkk +
(kk+ ,
truekk, 0
,kk0 1
HttpStatusCodekk2 @
.kk@ A
OKkkA C
,kkC D
_resultkkE L
)kkL M
;kkM N
}ll 	
}mm 
}nn ¢
eD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Handlers\Contracts\IHandler.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Handlers &
.& '
	Contracts' 0
{ 
public 

	interface 
IHandler 
< 
T 
>  
where! &
T' (
:) *
ICommand+ 3
{ 
Task 
< 
ICommandResult 
> 
Handle #
(# $
T$ %
command& -
)- .
;. /
}		 
}

 ≈=
fD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Handlers\ManufacturerHandler.cs
	namespace		 	
ComparaItens		
 
.		 
Domain		 
.		 
Handlers		 &
{

 
public 

class 
ManufacturerHandler $
:% &

Notifiable 
, 
IHandler 
< %
ManufacturerInsertCommand 6
>6 7
,7 8
IHandler 
< %
ManufacturerDeleteCommand 6
>6 7
,7 8
IHandler 
< %
ManufacturerUpdateCommand 6
>6 7
{ 
private 
readonly 
ICudRepository '
_cudRepository( 6
;6 7
private 
readonly #
IManufacturerRepository 0"
_manufactoryRepository1 G
;G H
public 
ManufacturerHandler "
(" #
ICudRepository# 1
cudRepository2 ?
,? @#
IManufacturerRepositoryA X!
manufactoryRepositoryY n
)n o
{ 	
_cudRepository 
= 
cudRepository *
;* +"
_manufactoryRepository "
=# $!
manufactoryRepository% :
;: ;
} 	
public 
async 
Task 
< 
ICommandResult (
>( )
Handle* 0
(0 1%
ManufacturerInsertCommand1 J
commandK R
)R S
{ 	
command 
. 
Validate 
( 
) 
; 
if 
( 
command 
. 
Invalid 
)  
return 
new  
GenericCommandResult /
(/ 0
false   !
,  ! "
HttpStatusCode!! *
.!!* +

BadRequest!!+ 5
,!!5 6
command"" #
.""# $
Notifications""$ 1
)""1 2
;""2 3
Manufacturer$$ 
_entity$$  
=$$! "
new$$# &
Manufacturer$$' 3
($$3 4
command$$4 ;
.$$; <
Description$$< G
)$$G H
;$$H I
var&& 
_result&& 
=&& 
await&& 
_cudRepository&&  .
.&&. /
Add&&/ 2
(&&2 3
_entity&&3 :
)&&: ;
;&&; <
if)) 
()) 
!)) 
_result)) 
))) 
return** 
new**  
GenericCommandResult** /
(**/ 0
false**0 5
,**5 6
HttpStatusCode**7 E
.**E F

BadRequest**F P
,**P Q
_result**R Y
)**Y Z
;**Z [
return,, 
new,,  
GenericCommandResult,, +
(,,+ ,
true,,, 0
,,,0 1
HttpStatusCode,,2 @
.,,@ A
Created,,A H
,,,H I
_result,,J Q
),,Q R
;,,R S
}-- 	
public// 
async// 
Task// 
<// 
ICommandResult// (
>//( )
Handle//* 0
(//0 1%
ManufacturerDeleteCommand//1 J
command//K R
)//R S
{00 	
command22 
.22 
Validate22 
(22 
)22 
;22 
if33 
(33 
command33 
.33 
Invalid33 
)33  
return44 
new44  
GenericCommandResult44 /
(44/ 0
false55 !
,55! "
HttpStatusCode66 *
.66* +

BadRequest66+ 5
,665 6
command77 #
.77# $
Notifications77$ 1
)771 2
;772 3
var99 
_verify99 
=99 
await99 "
_manufactoryRepository99  6
.996 7
FindById997 ?
(99? @
command99@ G
.99G H
Id99H J
)99J K
;99K L
if;; 
(;; 
_verify;; 
==;; 
null;; 
);;  
return<< 
new<<  
GenericCommandResult<< /
(<</ 0
false<<0 5
,<<5 6
HttpStatusCode<<7 E
.<<E F
NotFound<<F N
,<<N O
$str<<P h
)<<h i
;<<i j
Manufacturer>> 
_entity>>  
=>>! "
new>># &
Manufacturer>>' 3
(>>3 4
command>>4 ;
.>>; <
Id>>< >
)>>> ?
;>>? @
var@@ 
_result@@ 
=@@ 
await@@ 
_cudRepository@@  .
.@@. /
Delete@@/ 5
(@@5 6
_entity@@6 =
)@@= >
;@@> ?
ifCC 
(CC 
!CC 
_resultCC 
)CC 
returnDD 
newDD  
GenericCommandResultDD /
(DD/ 0
falseDD0 5
,DD5 6
HttpStatusCodeDD7 E
.DDE F

BadRequestDDF P
,DDP Q
_resultDDR Y
)DDY Z
;DDZ [
returnFF 
newFF  
GenericCommandResultFF +
(FF+ ,
trueFF, 0
,FF0 1
HttpStatusCodeFF2 @
.FF@ A
OKFFA C
,FFC D
_resultFFE L
)FFL M
;FFM N
}GG 	
publicII 
asyncII 
TaskII 
<II 
ICommandResultII (
>II( )
HandleII* 0
(II0 1%
ManufacturerUpdateCommandII1 J
commandIIK R
)IIR S
{JJ 	
commandLL 
.LL 
ValidateLL 
(LL 
)LL 
;LL 
ifMM 
(MM 
commandMM 
.MM 
InvalidMM 
)MM  
returnNN 
newNN  
GenericCommandResultNN /
(NN/ 0
falseOO !
,OO! "
HttpStatusCodePP *
.PP* +

BadRequestPP+ 5
,PP5 6
commandQQ #
.QQ# $
NotificationsQQ$ 1
)QQ1 2
;QQ2 3
varSS 
_verifySS 
=SS 
awaitSS "
_manufactoryRepositorySS  6
.SS6 7
FindByIdSS7 ?
(SS? @
commandSS@ G
.SSG H
IdSSH J
)SSJ K
;SSK L
ifUU 
(UU 
_verifyUU 
==UU 
nullUU 
)UU  
returnVV 
newVV  
GenericCommandResultVV /
(VV/ 0
falseVV0 5
,VV5 6
HttpStatusCodeVV7 E
.VVE F
NotFoundVVF N
,VVN O
$strVVP h
)VVh i
;VVi j
ManufacturerXX 
_entityXX  
=XX! "
newXX# &
ManufacturerXX' 3
(XX3 4
commandXX4 ;
.XX; <
IdXX< >
,XX> ?
commandXX@ G
.XXG H
DescriptionXXH S
)XXS T
;XXT U
varZZ 
_resultZZ 
=ZZ 
awaitZZ 
_cudRepositoryZZ  .
.ZZ. /
UpdateZZ/ 5
(ZZ5 6
_entityZZ6 =
)ZZ= >
;ZZ> ?
if]] 
(]] 
!]] 
_result]] 
)]] 
return^^ 
new^^  
GenericCommandResult^^ /
(^^/ 0
false^^0 5
,^^5 6
HttpStatusCode^^7 E
.^^E F

BadRequest^^F P
,^^P Q
_result^^R Y
)^^Y Z
;^^Z [
return`` 
new``  
GenericCommandResult`` +
(``+ ,
true``, 0
,``0 1
HttpStatusCode``2 @
.``@ A
OK``A C
,``C D
_result``E L
)``L M
;``M N
}aa 	
}bb 
}cc °I
aD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Handlers\ProductHandler.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Handlers &
{ 
public 

class 
ProductHandler 
:  !

Notifiable" ,
,, -
IHandler 
<  
ProductInsertCommand %
>% &
,& '
IHandler 
<  
ProductDeleteCommand %
>% &
,& '
IHandler 
<  
ProductUpdateCommand %
>% &
{ 
private 
readonly 
ICudRepository '
_cudRepository( 6
;6 7
private 
readonly 
IProductRepository +
_productRepository, >
;> ?
private 
readonly 
IHostingEnvironment ,
_env- 1
;1 2
public 
ProductHandler 
( 
ICudRepository ,
cudRepository- :
,: ;
IProductRepository< N
productRepositoryO `
,` a
IHostingEnvironmentb u
envv y
)y z
{ 	
_cudRepository 
= 
cudRepository *
;* +
_productRepository 
=  
productRepository! 2
;2 3
_env 
= 
env 
; 
} 	
public 
async 
Task 
< 
ICommandResult (
>( )
Handle* 0
(0 1 
ProductInsertCommand1 E
commandF M
)M N
{   	
command"" 
."" 
Validate"" 
("" 
)"" 
;"" 
if## 
(## 
command## 
.## 
Invalid## 
)##  
return$$ 
new$$  
GenericCommandResult$$ /
($$/ 0
false$$0 5
,$$5 6
HttpStatusCode$$7 E
.$$E F

BadRequest$$F P
,$$P Q
command$$R Y
.$$Y Z
Notifications$$Z g
)$$g h
;$$h i
var'' 
_entity'' 
='' 
new'' 
Product'' %
{(( 
Description)) 
=)) 
command)) %
.))% &
Description))& 1
,))1 2
ManufacturerId** 
=**  
command**! (
.**( )
ManufacturerId**) 7
,**7 8
Model++ 
=++ 
command++ 
.++  
Model++  %
,++% &

CategoryId,, 
=,, 
command,, $
.,,$ %

CategoryId,,% /
,,,/ 0
YearOfManufacture-- !
=--" #
command--$ +
.--+ ,
YearOfManufacture--, =
,--= >&
CharacteristicDescriptions.. *
=..+ ,
command..- 4
...4 5&
CharacteristicDescriptions..5 O
}// 
;// 
var11 
_result11 
=11 
await11 
_productRepository11  2
.112 3
Add113 6
(116 7
_entity117 >
)11> ?
;11? @
if44 
(44 
!44 
_result44 
)44 
return55 
new55  
GenericCommandResult55 /
(55/ 0
false550 5
,555 6
HttpStatusCode557 E
.55E F

BadRequest55F P
,55P Q
_result55R Y
)55Y Z
;55Z [
return77 
new77  
GenericCommandResult77 +
(77+ ,
true77, 0
,770 1
HttpStatusCode772 @
.77@ A
Created77A H
,77H I
_result77J Q
)77Q R
;77R S
}88 	
public:: 
async:: 
Task:: 
<:: 
ICommandResult:: (
>::( )
Handle::* 0
(::0 1 
ProductDeleteCommand::1 E
command::F M
)::M N
{;; 	
command== 
.== 
Validate== 
(== 
)== 
;== 
if>> 
(>> 
command>> 
.>> 
Invalid>> 
)>>  
return?? 
new??  
GenericCommandResult?? /
(??/ 0
false@@ 
,@@ 
HttpStatusCodeAA "
.AA" #

BadRequestAA# -
,AA- .
commandBB 
.BB 
NotificationsBB )
)BB) *
;BB* +
varDD 
_verifyDD 
=DD 
awaitDD 
_productRepositoryDD  2
.DD2 3
FindByIdDD3 ;
(DD; <
commandDD< C
.DDC D
IdDDD F
)DDF G
;DDG H
ifFF 
(FF 
_verifyFF 
==FF 
nullFF 
)FF  
returnGG 
newGG  
GenericCommandResultGG /
(GG/ 0
falseGG0 5
,GG5 6
HttpStatusCodeGG7 E
.GGE F
NotFoundGGF N
,GGN O
$strGGP h
)GGh i
;GGi j
varII 
productII 
=II 
newII 
ProductII %
{JJ 
IdKK 
=KK 
commandKK 
.KK 
IdKK 
}LL 
;LL 
varNN 
_resultNN 
=NN 
awaitNN 
_productRepositoryNN  2
.NN2 3
DeleteNN3 9
(NN9 :
productNN: A
)NNA B
;NNB C
ifQQ 
(QQ 
!QQ 
_resultQQ 
)QQ 
returnRR 
newRR  
GenericCommandResultRR /
(RR/ 0
falseRR0 5
,RR5 6
HttpStatusCodeRR7 E
.RRE F

BadRequestRRF P
,RRP Q
_resultRRR Y
)RRY Z
;RRZ [
returnTT 
newTT  
GenericCommandResultTT +
(TT+ ,
trueTT, 0
,TT0 1
HttpStatusCodeTT2 @
.TT@ A
OKTTA C
,TTC D
_resultTTE L
)TTL M
;TTM N
}UU 	
publicWW 
asyncWW 
TaskWW 
<WW 
ICommandResultWW (
>WW( )
HandleWW* 0
(WW0 1 
ProductUpdateCommandWW1 E
commandWWF M
)WWM N
{XX 	
commandZZ 
.ZZ 
ValidateZZ 
(ZZ 
)ZZ 
;ZZ 
if[[ 
([[ 
command[[ 
.[[ 
Invalid[[ 
)[[  
return\\ 
new\\  
GenericCommandResult\\ /
(\\/ 0
false]] 
,]] 
HttpStatusCode^^ "
.^^" #

BadRequest^^# -
,^^- .
command__ 
.__ 
Notifications__ )
)__) *
;__* +
varaa 
_verifyaa 
=aa 
awaitaa 
_productRepositoryaa  2
.aa2 3
FindByIdaa3 ;
(aa; <
commandaa< C
.aaC D
IdaaD F
)aaF G
;aaG H
ifcc 
(cc 
_verifycc 
==cc 
nullcc 
)cc  
returndd 
newdd  
GenericCommandResultdd /
(dd/ 0
falsedd0 5
,dd5 6
HttpStatusCodedd7 E
.ddE F
NotFoundddF N
,ddN O
$strddP h
)ddh i
;ddi j
varff 
productff 
=ff 
newff 
Productff %
{gg 
Idhh 
=hh 
commandhh 
.hh 
Idhh 
,hh  

CategoryIdii 
=ii 
commandii $
.ii$ %

CategoryIdii% /
,ii/ 0
Descriptionjj 
=jj 
commandjj %
.jj% &
Descriptionjj& 1
,jj1 2
ManufacturerIdkk 
=kk  
commandkk! (
.kk( )
ManufacturerIdkk) 7
,kk7 8
YearOfManufacturell !
=ll" #
commandll$ +
.ll+ ,
YearOfManufacturell, =
,ll= >
Modelmm 
=mm 
commandmm 
.mm  
Modelmm  %
,mm% &&
CharacteristicDescriptionsnn *
=nn+ ,
commandnn- 4
.nn4 5&
CharacteristicDescriptionsnn5 O
}oo 
;oo 
varqq 
_resultqq 
=qq 
awaitqq 
_productRepositoryqq  2
.qq2 3
Updateqq3 9
(qq9 :
productqq: A
)qqA B
;qqB C
iftt 
(tt 
!tt 
_resulttt 
)tt 
returnuu 
newuu  
GenericCommandResultuu /
(uu/ 0
falseuu0 5
,uu5 6
HttpStatusCodeuu7 E
.uuE F

BadRequestuuF P
,uuP Q
_resultuuR Y
)uuY Z
;uuZ [
returnww 
newww  
GenericCommandResultww +
(ww+ ,
trueww, 0
,ww0 1
HttpStatusCodeww2 @
.ww@ A
OKwwA C
,wwC D
_resultwwE L
)wwL M
;wwM N
}xx 	
}yy 
}zz ØY
^D:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Handlers\UserHandler.cs
	namespace

 	
ComparaItens


 
.

 
Domain

 
.

 
Handlers

 &
{ 
public 

class 
UserHandler 
: 

Notifiable )
,) *
IHandler 
< 
UserInsertCommand &
>& '
,' (
IHandler 
< 
UserDeleteCommand &
>& '
,' (
IHandler 
< 
UserUpdateCommand &
>& '
,' (
IHandler 
< %
UserValidateAccessCommand .
>. /
{ 
private 
readonly 
ICudRepository '
_cudRepository( 6
;6 7
private 
readonly 
IUserRepository (
_userRepository) 8
;8 9
public 
UserHandler 
( 
ICudRepository )
cudRepository* 7
,7 8
IUserRepository9 H
userRepositoryI W
)W X
{ 	
_cudRepository 
= 
cudRepository *
;* +
_userRepository 
= 
userRepository ,
;, -
} 	
public 
async 
Task 
< 
ICommandResult (
>( )
Handle* 0
(0 1
UserInsertCommand1 B
commandC J
)J K
{ 	
command 
. 
Validate 
( 
) 
; 
if 
( 
command 
. 
Invalid 
)  
return   
new    
GenericCommandResult   /
(  / 0
false  0 5
,  5 6
HttpStatusCode  7 E
.  E F

BadRequest  F P
,  P Q
command  R Y
.  Y Z
Notifications  Z g
)  g h
;  h i
User"" 
_entity"" 
="" 
new"" 
User"" #
(""# $
)""$ %
;""% &
_entity## 
.## 
Login## 
=## 
command## #
.### $
Login##$ )
;##) *
_entity$$ 
.$$ 
Password$$ 
=$$ 
command$$ &
.$$& '
Password$$' /
;$$/ 0
_entity%% 
.%% 
Name%% 
=%% 
command%% "
.%%" #
Name%%# '
;%%' (
_entity&& 
.&& 
Email&& 
=&& 
command&& #
.&&# $
Email&&$ )
;&&) *
_entity(( 
.(( 
Role(( 
=(( 
((( 
!(( 
string(( #
.((# $
IsNullOrEmpty(($ 1
(((1 2
command((2 9
.((9 :
Role((: >
)((> ?
)((? @
?((A B
command((C J
.((J K
Role((K O
:((P Q
$str((R a
;((a b
var** 
_result** 
=** 
await** 
_cudRepository**  .
.**. /
Add**/ 2
(**2 3
_entity**3 :
)**: ;
;**; <
if-- 
(-- 
!-- 
_result-- 
)-- 
return.. 
new..  
GenericCommandResult.. /
(../ 0
false..0 5
,..5 6
HttpStatusCode..7 E
...E F

BadRequest..F P
,..P Q
_result..R Y
)..Y Z
;..Z [
return00 
new00  
GenericCommandResult00 +
(00+ ,
true00, 0
,000 1
HttpStatusCode002 @
.00@ A
Created00A H
,00H I
_result00J Q
)00Q R
;00R S
}11 	
public33 
async33 
Task33 
<33 
ICommandResult33 (
>33( )
Handle33* 0
(330 1
UserDeleteCommand331 B
command33C J
)33J K
{44 	
command66 
.66 
Validate66 
(66 
)66 
;66 
if77 
(77 
command77 
.77 
Invalid77 
)77  
return88 
new88  
GenericCommandResult88 /
(88/ 0
false880 5
,885 6
HttpStatusCode887 E
.88E F

BadRequest88F P
,88P Q
command88R Y
.88Y Z
Notifications88Z g
)88g h
;88h i
var:: 
_verify:: 
=:: 
await:: 
_userRepository::  /
.::/ 0
FindById::0 8
(::8 9
command::9 @
.::@ A
Id::A C
)::C D
;::D E
if<< 
(<< 
_verify<< 
==<< 
null<< 
)<<  
return== 
new==  
GenericCommandResult== /
(==/ 0
false==0 5
,==5 6
HttpStatusCode==7 E
.==E F
NotFound==F N
,==N O
$str==P h
)==h i
;==i j
Manufacturer?? 
_entity??  
=??! "
new??# &
Manufacturer??' 3
(??3 4
command??4 ;
.??; <
Id??< >
)??> ?
;??? @
varAA 
_resultAA 
=AA 
awaitAA 
_cudRepositoryAA  .
.AA. /
DeleteAA/ 5
(AA5 6
_entityAA6 =
)AA= >
;AA> ?
ifDD 
(DD 
!DD 
_resultDD 
)DD 
returnEE 
newEE  
GenericCommandResultEE /
(EE/ 0
falseEE0 5
,EE5 6
HttpStatusCodeEE7 E
.EEE F

BadRequestEEF P
,EEP Q
_resultEER Y
)EEY Z
;EEZ [
returnGG 
newGG  
GenericCommandResultGG +
(GG+ ,
trueGG, 0
,GG0 1
HttpStatusCodeGG2 @
.GG@ A
OKGGA C
,GGC D
_resultGGE L
)GGL M
;GGM N
}HH 	
publicJJ 
asyncJJ 
TaskJJ 
<JJ 
ICommandResultJJ (
>JJ( )
HandleJJ* 0
(JJ0 1
UserUpdateCommandJJ1 B
commandJJC J
)JJJ K
{KK 	
commandMM 
.MM 
ValidateMM 
(MM 
)MM 
;MM 
ifNN 
(NN 
commandNN 
.NN 
InvalidNN 
)NN  
returnOO 
newOO  
GenericCommandResultOO /
(OO/ 0
falseOO0 5
,OO5 6
HttpStatusCodeOO7 E
.OOE F

BadRequestOOF P
,OOP Q
commandOOR Y
.OOY Z
NotificationsOOZ g
)OOg h
;OOh i
varQQ 
_verifyQQ 
=QQ 
awaitQQ 
_userRepositoryQQ  /
.QQ/ 0
FindByIdQQ0 8
(QQ8 9
commandQQ9 @
.QQ@ A
IdQQA C
)QQC D
;QQD E
ifSS 
(SS 
_verifySS 
==SS 
nullSS 
)SS  
returnTT 
newTT  
GenericCommandResultTT /
(TT/ 0
falseTT0 5
,TT5 6
HttpStatusCodeTT7 E
.TTE F
NotFoundTTF N
,TTN O
$strTTP h
)TTh i
;TTi j
UserVV 
_entityVV 
=VV 
newVV 
UserVV #
(VV# $
)VV$ %
;VV% &
_entityWW 
.WW 
IdWW 
=WW 
commandWW  
.WW  !
IdWW! #
;WW# $
_entityXX 
.XX 
LoginXX 
=XX 
_verifyXX #
.XX# $
LoginXX$ )
;XX) *
_entityYY 
.YY 
PasswordYY 
=YY 
commandYY &
.YY& '
PasswordYY' /
;YY/ 0
_entityZZ 
.ZZ 
NameZZ 
=ZZ 
commandZZ "
.ZZ" #
NameZZ# '
;ZZ' (
_entity[[ 
.[[ 
Role[[ 
=[[ 
([[ 
![[ 
string[[ #
.[[# $
IsNullOrEmpty[[$ 1
([[1 2
command[[2 9
.[[9 :
Role[[: >
)[[> ?
)[[? @
?[[A B
command[[C J
.[[J K
Role[[K O
:[[P Q
$str[[R a
;[[a b
var]] 
_result]] 
=]] 
await]] 
_cudRepository]]  .
.]]. /
Update]]/ 5
(]]5 6
_entity]]6 =
)]]= >
;]]> ?
if`` 
(`` 
!`` 
_result`` 
)`` 
returnaa 
newaa  
GenericCommandResultaa /
(aa/ 0
falseaa0 5
,aa5 6
HttpStatusCodeaa7 E
.aaE F

BadRequestaaF P
,aaP Q
_resultaaR Y
)aaY Z
;aaZ [
returncc 
newcc  
GenericCommandResultcc +
(cc+ ,
truecc, 0
,cc0 1
HttpStatusCodecc2 @
.cc@ A
OKccA C
,ccC D
_resultccE L
)ccL M
;ccM N
}dd 	
publicff 
asyncff 
Taskff 
<ff 
ICommandResultff (
>ff( )
Handleff* 0
(ff0 1%
UserValidateAccessCommandff1 J
commandffK R
)ffR S
{gg 	
commandii 
.ii 
Validateii 
(ii 
)ii 
;ii 
ifjj 
(jj 
commandjj 
.jj 
Invalidjj 
)jj  
returnkk 
newkk  
GenericCommandResultkk /
(kk/ 0
falsekk0 5
,kk5 6
HttpStatusCodekk7 E
.kkE F

BadRequestkkF P
,kkP Q
commandkkR Y
.kkY Z
NotificationskkZ g
)kkg h
;kkh i
varmm 
_resultmm 
=mm 
awaitmm 
_userRepositorymm  /
.mm/ 0

VerifyUsermm0 :
(mm: ;
commandmm; B
.mmB C
LoginmmC H
,mmH I
commandmmJ Q
.mmQ R
PasswordmmR Z
)mmZ [
;mm[ \
ifpp 
(pp 
_resultpp 
==pp 
nullpp 
)pp  
returnqq 
newqq  
GenericCommandResultqq /
(qq/ 0
falseqq0 5
,qq5 6
HttpStatusCodeqq7 E
.qqE F
NotFoundqqF N
,qqN O
_resultqqP W
)qqW X
;qqX Y
varss 
tokenss 
=ss 
TokenServicess $
.ss$ %
GenerateTokenss% 2
(ss2 3
_resultss3 :
)ss: ;
;ss; <
returnuu 
newuu  
GenericCommandResultuu +
(uu+ ,
trueuu, 0
,uu0 1
HttpStatusCodeuu2 @
.uu@ A
OKuuA C
,uuC D
newuuE H
{uuI J
_resultuuK R
,uuR S
tokenuuT Y
}uuZ [
)uu[ \
;uu\ ]
}vv 	
}ww 
}xx ç
jD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Repositories\ICategoryRepository.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Repositories *
{ 
public 

	interface 
ICategoryRepository (
{ 
Task		 
<		 
Category		 
>		 
FindById		 
(		  
int		  #
id		$ &
)		& '
;		' (
Task 
< 
IList 
< 
Category 
> 
> 
FindAll %
(% &
)& '
;' (
Task 
< 
Category 
> 
FindByDescription (
(( )
string) /
description0 ;
); <
;< =
} 
} í
{D:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Repositories\ICharacteristicDescriptionRepository.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Repositories *
{ 
public 

	interface 0
$ICharacteristicDescriptionRepository 9
{ 
Task		 
<		 %
CharacteristicDescription		 &
>		& '
FindById		( 0
(		0 1
int		1 4
id		5 7
)		7 8
;		8 9
Task 
< 
bool 
> 
DeleteByProductId $
($ %
int% (
	productId) 2
)2 3
;3 4
Task 
< 
IList 
< %
CharacteristicDescription ,
>, -
>- .
FindAll/ 6
(6 7
)7 8
;8 9
Task 
< %
CharacteristicDescription &
>& '
FindByDescription( 9
(9 :
string: @
descriptionA L
)L M
;M N
Task 
< 
IList 
< %
CharacteristicDescription ,
>, -
>- .
FindByProductId/ >
(> ?
int? B
	idProductC L
)L M
;M N
} 
} Ê
sD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Repositories\ICharacteristicKeyRepository.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Repositories *
{ 
public 

	interface (
ICharacteristicKeyRepository 1
{ 
Task		 
<		 
CharacteristicKey		 
>		 
FindById		  (
(		( )
int		) ,
id		- /
)		/ 0
;		0 1
Task 
< 
IList 
< 
CharacteristicKey $
>$ %
>% &
FindAll' .
(. /
)/ 0
;0 1
Task 
< 
IList 
< 
CharacteristicKey $
>$ %
>% & 
FindByAllDescription' ;
(; <
string< B
keyC F
)F G
;G H
} 
} ´
pD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Repositories\ICharacteristicRepository.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Repositories *
{ 
public 

	interface %
ICharacteristicRepository .
{ 
Task		 
<		 
Characteristic		 
>		 
FindById		 %
(		% &
int		& )
id		* ,
)		, -
;		- .
Task 
< 
IList 
< 
Characteristic !
>! "
>" #
FindAll$ +
(+ ,
), -
;- .
Task 
< 
Characteristic 
> 
FindByDescription .
(. /
string/ 5
description6 A
)A B
;B C
} 
} £	
eD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Repositories\ICudRepository.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Repositories *
{ 
public 

	interface 
ICudRepository #
{ 
Task 
< 
bool 
> 
Add 
< 
T 
> 
( 
T 
entity "
)" #
where$ )
T* +
:, -
class. 3
;3 4
Task		 
<		 
bool		 
>		 
Update		 
<		 
T		 
>		 
(		 
T		 
entity		 %
)		% &
where		' ,
T		- .
:		/ 0
class		1 6
;		6 7
Task 
< 
bool 
> 
Delete 
< 
T 
> 
( 
T 
entity %
)% &
where' ,
T- .
:/ 0
class1 6
;6 7
} 
} °
nD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Repositories\IManufacturerRepository.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Repositories *
{ 
public 

	interface #
IManufacturerRepository ,
{ 
Task		 
<		 
Manufacturer		 
>		 
FindById		 #
(		# $
int		$ '
id		( *
)		* +
;		+ ,
Task 
< 
IList 
< 
Manufacturer 
>  
>  !
FindAll" )
() *
)* +
;+ ,
Task 
< 
Manufacturer 
> 
FindByDescription ,
(, -
string- 3
description4 ?
)? @
;@ A
} 
} È
iD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Repositories\IProductRepository.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Repositories *
{ 
public 

	interface 
IProductRepository '
{ 
Task		 
<		 
bool		 
>		 
Add		 
(		 
Product		 
entity		 %
)		% &
;		& '
Task 
< 
bool 
> 
Update 
( 
Product !
entity" (
)( )
;) *
Task 
< 
bool 
> 
Delete 
( 
Product !
entity" (
)( )
;) *
Task 
< 
IList 
< 
Product 
> 
> 
FindAll $
($ %
)% &
;& '
Task 
< 
Product 
> 
FindById 
( 
int "
id# %
)% &
;& '
Task 
< 
IList 
< 
Product 
> 
> 
FindByParameters -
(- .
int. 1

categoryId2 <
,< =
int> A
manufacturerIdB P
,P Q
intR U
characteristicIdV f
,f g
stringh n
keyo r
,r s
stringt z
keyDescription	{ â
,
â ä
string
ã ë
description
í ù
)
ù û
;
û ü
} 
} •
fD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Repositories\IUserRepository.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Repositories *
{ 
public 

	interface 
IUserRepository $
{ 
Task		 
<		 
User		 
>		 
FindById		 
(		 
int		 
id		  "
)		" #
;		# $
Task 
< 
IList 
< 
User 
> 
> 
FindAll !
(! "
)" #
;# $
Task 
< 
User 
> 

VerifyUser 
( 
string $
login% *
,* +
string, 2
password3 ;
); <
;< =
} 
} í
_D:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Services\TokenService.cs
	namespace 	
ComparaItens
 
. 
Domain 
. 
Services &
{		 
public

 

static

 
class

 
TokenService

 $
{ 
public 
static 
string 
GenerateToken *
(* +
User+ /
user0 4
)4 5
{ 	
var 
tokenHandler 
= 
new "#
JwtSecurityTokenHandler# :
(: ;
); <
;< =
var 
key 
= 
Encoding 
. 
ASCII $
.$ %
GetBytes% -
(- .
Settings. 6
.6 7
Secret7 =
)= >
;> ?
var 
tokenDescriptor 
=  !
new" %#
SecurityTokenDescriptor& =
{ 
Subject 
= 
new 
ClaimsIdentity ,
(, -
new- 0
Claim1 6
[6 7
]7 8
{ 
new 
Claim 
( 

ClaimTypes (
.( )
Name) -
,- .
user/ 3
.3 4
Login4 9
.9 :
ToString: B
(B C
)C D
)D E
,E F
new 
Claim 
( 

ClaimTypes (
.( )
Role) -
,- .
user/ 3
.3 4
Role4 8
.8 9
ToString9 A
(A B
)B C
)C D
} 
) 
, 
Expires 
= 
DateTime "
." #
UtcNow# )
.) *
AddHours* 2
(2 3
$num3 4
)4 5
,5 6
SigningCredentials "
=# $
new% (
SigningCredentials) ;
(; <
new< ? 
SymmetricSecurityKey@ T
(T U
keyU X
)X Y
,Y Z
SecurityAlgorithms[ m
.m n 
HmacSha256Signature	n Å
)
Å Ç
} 
; 
var 
token 
= 
tokenHandler $
.$ %
CreateToken% 0
(0 1
tokenDescriptor1 @
)@ A
;A B
return 
tokenHandler 
.  

WriteToken  *
(* +
token+ 0
)0 1
;1 2
} 	
} 
} Ø
RD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Domain\Settings.cs
	namespace 	
ComparaItens
 
. 
Domain 
{ 
public 

static 
class 
Settings  
{ 
public 
static 
string 
Secret #
=$ %
$str& H
;H I
} 
} 