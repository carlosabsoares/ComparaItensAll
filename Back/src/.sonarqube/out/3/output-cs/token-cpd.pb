º0
eD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Api\Controllers\CategoryController.cs
	namespace

 	
ComparaItens


 
.

 
Api

 
.

 
Controllers

 &
{ 
[ 
ApiController 
] 
[ 
Route 

(
 
$str 
) 
] 
public 

class 
CategoryController #
:$ %
ControllerBase& 4
{ 
[ 	
HttpPost	 
( 
$str #
)# $
]$ %
[ 	
	Authorize	 
( 
Roles 
= 
$str *
)* +
]+ ,
[ 	 
ProducesResponseType	 
( 
typeof $
($ %
bool% )
)) *
,* +
$num, /
)/ 0
]0 1
public 
async 
Task 
<  
GenericCommandResult .
>. /
PostCategory0 <
(< =
[ 
FromBody 
] !
CategoryInsertCommand ,
command- 4
,4 5
[ 
FromServices 
] 
IHandler #
<# $!
CategoryInsertCommand$ 9
>9 :
handler; B
)B C
{ 	
return 
(  
GenericCommandResult (
)( )
await) .
handler/ 6
.6 7
Handle7 =
(= >
command> E
)E F
;F G
} 	
[ 	

HttpDelete	 
( 
$str %
)% &
]& '
[ 	
	Authorize	 
( 
Roles 
= 
$str *
)* +
]+ ,
[   	 
ProducesResponseType  	 
(   
typeof   $
(  $ %
bool  % )
)  ) *
,  * +
$num  , /
)  / 0
]  0 1
public!! 
async!! 
Task!! 
<!!  
GenericCommandResult!! .
>!!. /
DeleteCategory!!0 >
(!!> ?
[## 
	FromQuery## 
]## 
int## 
id## 
,## 
[$$ 
FromServices$$ 
]$$ 
IHandler$$ #
<$$# $!
CategoryDeleteCommand$$$ 9
>$$9 :
handler$$; B
)$$B C
{%% 	
var&& 
command&& 
=&& 
new&& !
CategoryDeleteCommand&& 3
(&&3 4
id&&4 6
)&&6 7
;&&7 8
return(( 
(((  
GenericCommandResult(( (
)((( )
await(() .
handler((/ 6
.((6 7
Handle((7 =
(((= >
command((> E
)((E F
;((F G
})) 	
[-- 	
HttpPut--	 
(-- 
$str-- "
)--" #
]--# $
[.. 	
	Authorize..	 
(.. 
Roles.. 
=.. 
$str.. *
)..* +
]..+ ,
[// 	 
ProducesResponseType//	 
(// 
typeof// $
(//$ %
bool//% )
)//) *
,//* +
$num//, /
)/// 0
]//0 1
public00 
async00 
Task00 
<00  
GenericCommandResult00 .
>00. /
UpdateCategory000 >
(00> ?
[11 
FromBody11 
]11 !
CategoryUpdateCommand11 ,
command11- 4
,114 5
[22 
FromServices22 
]22 
IHandler22 #
<22# $!
CategoryUpdateCommand22$ 9
>229 :
handler22; B
)22B C
{33 	
return44 
(44  
GenericCommandResult44 (
)44( )
await44) .
handler44/ 6
.446 7
Handle447 =
(44= >
command44> E
)44E F
;44F G
}55 	
[99 	
HttpGet99	 
(99 
$str99 #
)99# $
]99$ %
[:: 	
AllowAnonymous::	 
]:: 
[;; 	 
ProducesResponseType;;	 
(;; 
typeof;; $
(;;$ %
IList;;% *
<;;* +
Category;;+ 3
>;;3 4
);;4 5
,;;5 6
$num;;7 :
);;: ;
];;; <
public<< 
async<< 
Task<< 
<<< 
IList<< 
<<<  
Category<<  (
><<( )
><<) *
FindAllCategory<<+ :
(<<: ;
[== 
FromServices== 
]== 
ICategoryRepository== .

repository==/ 9
)==9 :
{>> 	
var?? 
result?? 
=?? 
await?? 

repository?? )
.??) *
FindAll??* 1
(??1 2
)??2 3
;??3 4
returnAA 
resultAA 
;AA 
}BB 	
[FF 	
HttpGetFF	 
(FF 
$strFF $
)FF$ %
]FF% &
[GG 	
AllowAnonymousGG	 
]GG 
[HH 	 
ProducesResponseTypeHH	 
(HH 
typeofHH $
(HH$ %
IListHH% *
<HH* +
CategoryHH+ 3
>HH3 4
)HH4 5
,HH5 6
$numHH7 :
)HH: ;
]HH; <
publicII 
asyncII 
TaskII 
<II 
CategoryII "
>II" #
FindByIdCategoryII$ 4
(II4 5
[JJ 
	FromQueryJJ 
]JJ 
intJJ 
idJJ 
,JJ 
[KK 
FromServicesKK 
]KK 
ICategoryRepositoryKK .

repositoryKK/ 9
)KK9 :
{LL 	
varMM 
resultMM 
=MM 
awaitMM 

repositoryMM )
.MM) *
FindByIdMM* 2
(MM2 3
idMM3 5
)MM5 6
;MM6 7
returnOO 
resultOO 
;OO 
}PP 	
}QQ 
}RR Æ1
kD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Api\Controllers\CharacteristicController.cs
	namespace 	
ComparaItens
 
. 
Api 
. 
Controllers &
{ 
[ 
ApiController 
] 
[ 
Route 

(
 
$str 
) 
] 
public 

class $
CharacteristicController )
:* +
ControllerBase, :
{ 
[ 	
HttpPost	 
( 
$str )
)) *
]* +
[ 	
	Authorize	 
( 
Roles 
= 
$str *
)* +
]+ ,
[ 	 
ProducesResponseType	 
( 
typeof $
($ %
bool% )
)) *
,* +
$num, /
)/ 0
]0 1
public 
async 
Task 
<  
GenericCommandResult .
>. /
PostCharacteristic0 B
(B C
[ 
FromBody 
] '
CharacteristicInsertCommand 2
command3 :
,: ;
[ 
FromServices 
] 
IHandler #
<# $'
CharacteristicInsertCommand$ ?
>? @
handlerA H
)H I
{ 	
return 
(  
GenericCommandResult (
)( )
await) .
handler/ 6
.6 7
Handle7 =
(= >
command> E
)E F
;F G
} 	
[   	

HttpDelete  	 
(   
$str   +
)  + ,
]  , -
[!! 	
	Authorize!!	 
(!! 
Roles!! 
=!! 
$str!! *
)!!* +
]!!+ ,
["" 	 
ProducesResponseType""	 
("" 
typeof"" $
(""$ %
bool""% )
)"") *
,""* +
$num"", /
)""/ 0
]""0 1
public## 
async## 
Task## 
<##  
GenericCommandResult## .
>##. / 
DeleteCharacteristic##0 D
(##D E
[%% 
	FromQuery%% 
]%% 
int%% 
id%% 
,%% 
[&& 
FromServices&& 
]&& 
IHandler&& #
<&&# $'
CharacteristicDeleteCommand&&$ ?
>&&? @
handler&&A H
)&&H I
{'' 	
var(( 
command(( 
=(( 
new(( '
CharacteristicDeleteCommand(( 9
(((9 :
id((: <
)((< =
;((= >
return** 
(**  
GenericCommandResult** (
)**( )
await**) .
handler**/ 6
.**6 7
Handle**7 =
(**= >
command**> E
)**E F
;**F G
}++ 	
[// 	
HttpPut//	 
(// 
$str// (
)//( )
]//) *
[00 	
	Authorize00	 
(00 
Roles00 
=00 
$str00 *
)00* +
]00+ ,
[11 	 
ProducesResponseType11	 
(11 
typeof11 $
(11$ %
bool11% )
)11) *
,11* +
$num11, /
)11/ 0
]110 1
public22 
async22 
Task22 
<22  
GenericCommandResult22 .
>22. / 
UpdateCharacteristic220 D
(22D E
[33 
FromBody33 
]33 '
CharacteristicUpdateCommand33 2
command333 :
,33: ;
[44 
FromServices44 
]44 
IHandler44 #
<44# $'
CharacteristicUpdateCommand44$ ?
>44? @
handler44A H
)44H I
{55 	
return66 
(66  
GenericCommandResult66 (
)66( )
await66) .
handler66/ 6
.666 7
Handle667 =
(66= >
command66> E
)66E F
;66F G
}77 	
[;; 	
HttpGet;;	 
(;; 
$str;; )
);;) *
];;* +
[<< 	
AllowAnonymous<<	 
]<< 
[== 	 
ProducesResponseType==	 
(== 
typeof== $
(==$ %
IList==% *
<==* +
Characteristic==+ 9
>==9 :
)==: ;
,==; <
$num=== @
)==@ A
]==A B
public>> 
async>> 
Task>> 
<>> 
IList>> 
<>>  
Characteristic>>  .
>>>. /
>>>/ 0!
FindAllCharacteristic>>1 F
(>>F G
[?? 
FromServices?? 
]?? %
ICharacteristicRepository?? 4

repository??5 ?
)??? @
{@@ 	
varAA 
resultAA 
=AA 
awaitAA 

repositoryAA )
.AA) *
FindAllAA* 1
(AA1 2
)AA2 3
;AA3 4
returnCC 
resultCC 
;CC 
}DD 	
[HH 	
HttpGetHH	 
(HH 
$strHH *
)HH* +
]HH+ ,
[II 	
AllowAnonymousII	 
]II 
[JJ 	 
ProducesResponseTypeJJ	 
(JJ 
typeofJJ $
(JJ$ %
IListJJ% *
<JJ* +
CharacteristicJJ+ 9
>JJ9 :
)JJ: ;
,JJ; <
$numJJ= @
)JJ@ A
]JJA B
publicKK 
asyncKK 
TaskKK 
<KK 
CharacteristicKK (
>KK( )"
FindByIdCharacteristicKK* @
(KK@ A
[LL 
	FromQueryLL 
]LL 
intLL 
idLL 
,LL 
[MM 
FromServicesMM 
]MM %
ICharacteristicRepositoryMM 4

repositoryMM5 ?
)MM? @
{NN 	
varOO 
resultOO 
=OO 
awaitOO 

repositoryOO )
.OO) *
FindByIdOO* 2
(OO2 3
idOO3 5
)OO5 6
;OO6 7
returnQQ 
resultQQ 
;QQ 
}RR 	
}SS 
}TT ˇ2
vD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Api\Controllers\CharacteristicDescriptionController.cs
	namespace

 	
ComparaItens


 
.

 
Api

 
.

 
Controllers

 &
{ 
[ 
ApiController 
] 
[ 
Route 

(
 
$str 
) 
] 
public 

class /
#CharacteristicDescriptionController 4
:5 6
ControllerBase7 E
{ 
[ 	
HttpPost	 
( 
$str 4
)4 5
]5 6
[ 	
	Authorize	 
( 
Roles 
= 
$str *
)* +
]+ ,
[ 	 
ProducesResponseType	 
( 
typeof $
($ %
bool% )
)) *
,* +
$num, /
)/ 0
]0 1
public 
async 
Task 
<  
GenericCommandResult .
>. /)
PostCharacteristicDescription0 M
(M N
[ 
FromBody 
] 2
&CharacteristicDescriptionInsertCommand =
command> E
,E F
[ 
FromServices 
] 
IHandler #
<# $2
&CharacteristicDescriptionInsertCommand$ J
>J K
handlerL S
)S T
{ 	
return 
(  
GenericCommandResult (
)( )
await) .
handler/ 6
.6 7
Handle7 =
(= >
command> E
)E F
;F G
} 	
[ 	

HttpDelete	 
( 
$str 6
)6 7
]7 8
[ 	
	Authorize	 
( 
Roles 
= 
$str *
)* +
]+ ,
[   	 
ProducesResponseType  	 
(   
typeof   $
(  $ %
bool  % )
)  ) *
,  * +
$num  , /
)  / 0
]  0 1
public!! 
async!! 
Task!! 
<!!  
GenericCommandResult!! .
>!!. /+
DeleteCharacteristicDescription!!0 O
(!!O P
["" 
	FromQuery"" 
]"" 
int"" 
id"" 
,"" 
[## 
FromServices## 
]## 
IHandler## #
<### $2
&CharacteristicDescriptionDeleteCommand##$ J
>##J K
handler##L S
)##S T
{$$ 	
var%% 
command%% 
=%% 
new%% 2
&CharacteristicDescriptionDeleteCommand%% D
(%%D E
id%%E G
)%%G H
;%%H I
return'' 
(''  
GenericCommandResult'' (
)''( )
await'') .
handler''/ 6
.''6 7
Handle''7 =
(''= >
command''> E
)''E F
;''F G
}(( 	
[,, 	
HttpPut,,	 
(,, 
$str,, 3
),,3 4
],,4 5
[-- 	
	Authorize--	 
(-- 
Roles-- 
=-- 
$str-- *
)--* +
]--+ ,
[.. 	 
ProducesResponseType..	 
(.. 
typeof.. $
(..$ %
bool..% )
)..) *
,..* +
$num.., /
)../ 0
]..0 1
public// 
async// 
Task// 
<//  
GenericCommandResult// .
>//. /+
UpdateCharacteristicDescription//0 O
(//O P
[00 
FromBody00 
]00 2
&CharacteristicDescriptionUpdateCommand00 =
command00> E
,00E F
[11 
FromServices11 
]11 
IHandler11 #
<11# $2
&CharacteristicDescriptionUpdateCommand11$ J
>11J K
handler11L S
)11S T
{22 	
return33 
(33  
GenericCommandResult33 (
)33( )
await33) .
handler33/ 6
.336 7
Handle337 =
(33= >
command33> E
)33E F
;33F G
}44 	
[88 	
HttpGet88	 
(88 
$str88 4
)884 5
]885 6
[99 	
AllowAnonymous99	 
]99 
[:: 	 
ProducesResponseType::	 
(:: 
typeof:: $
(::$ %
IList::% *
<::* +%
CharacteristicDescription::+ D
>::D E
)::E F
,::F G
$num::H K
)::K L
]::L M
public;; 
async;; 
Task;; 
<;; 
IList;; 
<;;  %
CharacteristicDescription;;  9
>;;9 :
>;;: ;,
 FindAllCharacteristicDescription;;< \
(;;\ ]
[<< 
FromServices<< 
]<< 0
$ICharacteristicDescriptionRepository<< ?

repository<<@ J
)<<J K
{== 	
var>> 
result>> 
=>> 
await>> 

repository>> )
.>>) *
FindAll>>* 1
(>>1 2
)>>2 3
;>>3 4
return@@ 
result@@ 
;@@ 
}AA 	
[EE 	
HttpGetEE	 
(EE 
$strEE 5
)EE5 6
]EE6 7
[FF 	
AllowAnonymousFF	 
]FF 
[GG 	 
ProducesResponseTypeGG	 
(GG 
typeofGG $
(GG$ %
IListGG% *
<GG* +%
CharacteristicDescriptionGG+ D
>GGD E
)GGE F
,GGF G
$numGGH K
)GGK L
]GGL M
publicHH 
asyncHH 
TaskHH 
<HH %
CharacteristicDescriptionHH 3
>HH3 4-
!FindByIdCharacteristicDescriptionHH5 V
(HHV W
[II 
	FromQueryII 
]II 
intII 
idII 
,II 
[JJ 
FromServicesJJ 
]JJ 0
$ICharacteristicDescriptionRepositoryJJ ?

repositoryJJ@ J
)JJJ K
{KK 	
varLL 
resultLL 
=LL 
awaitLL 

repositoryLL )
.LL) *
FindByIdLL* 2
(LL2 3
idLL3 5
)LL5 6
;LL6 7
returnNN 
resultNN 
;NN 
}OO 	
}PP 
}QQ :
nD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Api\Controllers\CharacteristicKeyController.cs
	namespace

 	
ComparaItens


 
.

 
Api

 
.

 
Controllers

 &
{ 
[ 
ApiController 
] 
[ 
Route 

(
 
$str 
) 
] 
public 

class '
CharacteristicKeyController ,
:- .
ControllerBase/ =
{ 
[ 	
HttpPost	 
( 
$str ,
), -
]- .
[ 	
	Authorize	 
( 
Roles 
= 
$str *
)* +
]+ ,
[ 	 
ProducesResponseType	 
( 
typeof $
($ %
bool% )
)) *
,* +
$num, /
)/ 0
]0 1
public 
async 
Task 
<  
GenericCommandResult .
>. /
PostCharacteristic0 B
(B C
[ 
FromBody 
] *
CharacteristicKeyInsertCommand 5
command6 =
,= >
[ 
FromServices 
] 
IHandler #
<# $*
CharacteristicKeyInsertCommand$ B
>B C
handlerD K
)K L
{ 	
return 
(  
GenericCommandResult (
)( )
await) .
handler/ 6
.6 7
Handle7 =
(= >
command> E
)E F
;F G
} 	
[ 	

HttpDelete	 
( 
$str .
). /
]/ 0
[ 	
	Authorize	 
( 
Roles 
= 
$str *
)* +
]+ ,
[   	 
ProducesResponseType  	 
(   
typeof   $
(  $ %
bool  % )
)  ) *
,  * +
$num  , /
)  / 0
]  0 1
public!! 
async!! 
Task!! 
<!!  
GenericCommandResult!! .
>!!. / 
DeleteCharacteristic!!0 D
(!!D E
[## 
	FromQuery## 
]## 
int## 
id## 
,## 
[$$ 
FromServices$$ 
]$$ 
IHandler$$ #
<$$# $*
CharacteristicKeyDeleteCommand$$$ B
>$$B C
handler$$D K
)$$K L
{%% 	
var&& 
command&& 
=&& 
new&& *
CharacteristicKeyDeleteCommand&& <
(&&< =
id&&= ?
)&&? @
;&&@ A
return(( 
(((  
GenericCommandResult(( (
)((( )
await(() .
handler((/ 6
.((6 7
Handle((7 =
(((= >
command((> E
)((E F
;((F G
})) 	
[-- 	
HttpPut--	 
(-- 
$str-- +
)--+ ,
]--, -
[.. 	
	Authorize..	 
(.. 
Roles.. 
=.. 
$str.. *
)..* +
]..+ ,
[// 	 
ProducesResponseType//	 
(// 
typeof// $
(//$ %
bool//% )
)//) *
,//* +
$num//, /
)/// 0
]//0 1
public00 
async00 
Task00 
<00  
GenericCommandResult00 .
>00. / 
UpdateCharacteristic000 D
(00D E
[11 
FromBody11 
]11 *
CharacteristicKeyUpdateCommand11 5
command116 =
,11= >
[22 
FromServices22 
]22 
IHandler22 #
<22# $*
CharacteristicKeyUpdateCommand22$ B
>22B C
handler22D K
)22K L
{33 	
return44 
(44  
GenericCommandResult44 (
)44( )
await44) .
handler44/ 6
.446 7
Handle447 =
(44= >
command44> E
)44E F
;44F G
}55 	
[99 	
HttpGet99	 
(99 
$str99 ,
)99, -
]99- .
[:: 	
AllowAnonymous::	 
]:: 
[;; 	 
ProducesResponseType;;	 
(;; 
typeof;; $
(;;$ %
IList;;% *
<;;* +
CharacteristicKey;;+ <
>;;< =
);;= >
,;;> ?
$num;;@ C
);;C D
];;D E
public<< 
async<< 
Task<< 
<<< 
IList<< 
<<<  
CharacteristicKey<<  1
><<1 2
><<2 3!
FindAllCharacteristic<<4 I
(<<I J
[== 
FromServices== 
]== (
ICharacteristicKeyRepository== 7

repository==8 B
)==B C
{>> 	
var?? 
result?? 
=?? 
await?? 

repository?? )
.??) *
FindAll??* 1
(??1 2
)??2 3
;??3 4
returnAA 
resultAA 
;AA 
}BB 	
[FF 	
HttpGetFF	 
(FF 
$strFF -
)FF- .
]FF. /
[GG 	
AllowAnonymousGG	 
]GG 
[HH 	 
ProducesResponseTypeHH	 
(HH 
typeofHH $
(HH$ %
IListHH% *
<HH* +
CharacteristicKeyHH+ <
>HH< =
)HH= >
,HH> ?
$numHH@ C
)HHC D
]HHD E
publicII 
asyncII 
TaskII 
<II 
CharacteristicKeyII +
>II+ ,"
FindByIdCharacteristicII- C
(IIC D
[JJ 
	FromQueryJJ 
]JJ 
intJJ 
idJJ 
,JJ 
[KK 
FromServicesKK 
]KK (
ICharacteristicKeyRepositoryKK 7

repositoryKK8 B
)KKB C
{LL 	
varMM 
resultMM 
=MM 
awaitMM 

repositoryMM )
.MM) *
FindByIdMM* 2
(MM2 3
idMM3 5
)MM5 6
;MM6 7
returnOO 
resultOO 
;OO 
}PP 	
[TT 	
HttpGetTT	 
(TT 
$strTT 6
)TT6 7
]TT7 8
[UU 	
AllowAnonymousUU	 
]UU 
[VV 	 
ProducesResponseTypeVV	 
(VV 
typeofVV $
(VV$ %
IListVV% *
<VV* +
CharacteristicKeyVV+ <
>VV< =
)VV= >
,VV> ?
$numVV@ C
)VVC D
]VVD E
publicWW 
asyncWW 
TaskWW 
<WW 
IListWW 
<WW  
CharacteristicKeyWW  1
>WW1 2
>WW2 3
FindByDescriptionWW4 E
(WWE F
[XX 
	FromQueryXX 
]XX 
stringXX 
descriptionXX *
,XX* +
[YY 
FromServicesYY 
]YY (
ICharacteristicKeyRepositoryYY 7

repositoryYY8 B
)YYB C
{ZZ 	
var[[ 
result[[ 
=[[ 
await[[ 

repository[[ )
.[[) * 
FindByAllDescription[[* >
([[> ?
description[[? J
)[[J K
;[[K L
return\\ 
result\\ 
;\\ 
}]] 	
}^^ 
}__ û1
iD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Api\Controllers\ManufacturerController.cs
	namespace

 	
ComparaItens


 
.

 
Api

 
.

 
Controllers

 &
{ 
[ 
ApiController 
] 
[ 
Route 

(
 
$str 
) 
] 
public 

class "
ManufacturerController '
:( )
ControllerBase* 8
{ 
[ 	
HttpPost	 
( 
$str '
)' (
]( )
[ 	
	Authorize	 
( 
Roles 
= 
$str *
)* +
]+ ,
[ 	 
ProducesResponseType	 
( 
typeof $
($ %
bool% )
)) *
,* +
$num, /
)/ 0
]0 1
public 
async 
Task 
<  
GenericCommandResult .
>. /
PostManufacturer0 @
(@ A
[ 
FromBody 
] %
ManufacturerInsertCommand 0
command1 8
,8 9
[ 
FromServices 
] 
IHandler #
<# $%
ManufacturerInsertCommand$ =
>= >
handler? F
)F G
{ 	
return 
(  
GenericCommandResult (
)( )
await) .
handler/ 6
.6 7
Handle7 =
(= >
command> E
)E F
;F G
} 	
[ 	

HttpDelete	 
( 
$str )
)) *
]* +
[ 	
	Authorize	 
( 
Roles 
= 
$str *
)* +
]+ ,
[   	 
ProducesResponseType  	 
(   
typeof   $
(  $ %
bool  % )
)  ) *
,  * +
$num  , /
)  / 0
]  0 1
public!! 
async!! 
Task!! 
<!!  
GenericCommandResult!! .
>!!. /
DeleteManufacturer!!0 B
(!!B C
[## 
	FromQuery## 
]## 
int## 
id## 
,## 
[$$ 
FromServices$$ 
]$$ 
IHandler$$ #
<$$# $%
ManufacturerDeleteCommand$$$ =
>$$= >
handler$$? F
)$$F G
{%% 	%
ManufacturerDeleteCommand&& %
command&&& -
=&&. /
new&&0 3%
ManufacturerDeleteCommand&&4 M
(&&M N
id&&N P
)&&P Q
;&&Q R
return(( 
(((  
GenericCommandResult(( (
)((( )
await(() .
handler((/ 6
.((6 7
Handle((7 =
(((= >
command((> E
)((E F
;((F G
})) 	
[-- 	
HttpPut--	 
(-- 
$str-- &
)--& '
]--' (
[.. 	
	Authorize..	 
(.. 
Roles.. 
=.. 
$str.. *
)..* +
]..+ ,
[// 	 
ProducesResponseType//	 
(// 
typeof// $
(//$ %
bool//% )
)//) *
,//* +
$num//, /
)/// 0
]//0 1
public00 
async00 
Task00 
<00  
GenericCommandResult00 .
>00. /
UpdateManufacturer000 B
(00B C
[11 
FromBody11 
]11 %
ManufacturerUpdateCommand11 0
command111 8
,118 9
[22 
FromServices22 
]22 
IHandler22 #
<22# $%
ManufacturerUpdateCommand22$ =
>22= >
handler22? F
)22F G
{33 	
return44 
(44  
GenericCommandResult44 (
)44( )
await44) .
handler44/ 6
.446 7
Handle447 =
(44= >
command44> E
)44E F
;44F G
}55 	
[99 	
HttpGet99	 
(99 
$str99 '
)99' (
]99( )
[:: 	
AllowAnonymous::	 
]:: 
[;; 	 
ProducesResponseType;;	 
(;; 
typeof;; $
(;;$ %
IList;;% *
<;;* +
Manufacturer;;+ 7
>;;7 8
);;8 9
,;;9 :
$num;;; >
);;> ?
];;? @
public<< 
async<< 
Task<< 
<<< 
IList<< 
<<<  
Manufacturer<<  ,
><<, -
><<- .
FindAllManufacturer<</ B
(<<B C
[== 
FromServices== 
]== #
IManufacturerRepository== 2

repository==3 =
)=== >
{>> 	
var?? 
result?? 
=?? 
await?? 

repository?? )
.??) *
FindAll??* 1
(??1 2
)??2 3
;??3 4
returnAA 
resultAA 
;AA 
}BB 	
[FF 	
HttpGetFF	 
(FF 
$strFF (
)FF( )
]FF) *
[GG 	
AllowAnonymousGG	 
]GG 
[HH 	 
ProducesResponseTypeHH	 
(HH 
typeofHH $
(HH$ %
IListHH% *
<HH* +
ManufacturerHH+ 7
>HH7 8
)HH8 9
,HH9 :
$numHH; >
)HH> ?
]HH? @
publicII 
asyncII 
TaskII 
<II 
ManufacturerII &
>II& ' 
FindByIdManufacturerII( <
(II< =
[JJ 
	FromQueryJJ 
]JJ 
intJJ 
idJJ 
,JJ 
[KK 
FromServicesKK 
]KK #
IManufacturerRepositoryKK 2

repositoryKK3 =
)KK= >
{LL 	
varMM 
resultMM 
=MM 
awaitMM 

repositoryMM )
.MM) *
FindByIdMM* 2
(MM2 3
idMM3 5
)MM5 6
;MM6 7
returnOO 
resultOO 
;OO 
}PP 	
}QQ 
}RR ØB
dD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Api\Controllers\ProductController.cs
	namespace 	
ComparaItens
 
. 
Api 
. 
Controllers &
{ 
[ 
ApiController 
] 
[ 
Route 

(
 
$str 
) 
] 
public 

class 
ProductController "
:# $
ControllerBase% 3
{ 
[ 	
System	 
. 
Obsolete 
] 
private 
readonly 
IHostingEnvironment ,
_env- 1
;1 2
[ 	
System	 
. 
Obsolete 
] 
public 
ProductController  
(  !
IHostingEnvironment! 4
env5 8
)8 9
{ 	
_env 
= 
env 
; 
} 	
[ 	
HttpPost	 
( 
$str "
)" #
]# $
[   	
	Authorize  	 
(   
Roles   
=   
$str   *
)  * +
]  + ,
[!! 	 
ProducesResponseType!!	 
(!! 
typeof!! $
(!!$ %
bool!!% )
)!!) *
,!!* +
$num!!, /
)!!/ 0
]!!0 1
public"" 
async"" 
Task"" 
<""  
GenericCommandResult"" .
>"". /
PostManufacturer""0 @
(""@ A
[## 
FromBody## 
]##  
ProductInsertCommand## +
command##, 3
,##3 4
[$$ 
FromServices$$ 
]$$ 
IHandler$$ #
<$$# $ 
ProductInsertCommand$$$ 8
>$$8 9
handler$$: A
)$$A B
{%% 	
return&& 
(&&  
GenericCommandResult&& (
)&&( )
await&&) .
handler&&/ 6
.&&6 7
Handle&&7 =
(&&= >
command&&> E
)&&E F
;&&F G
}'' 	
[++ 	

HttpDelete++	 
(++ 
$str++ $
)++$ %
]++% &
[,, 	
	Authorize,,	 
(,, 
Roles,, 
=,, 
$str,, *
),,* +
],,+ ,
[-- 	 
ProducesResponseType--	 
(-- 
typeof-- $
(--$ %
bool--% )
)--) *
,--* +
$num--, /
)--/ 0
]--0 1
public.. 
async.. 
Task.. 
<..  
GenericCommandResult.. .
>... /
DeleteProduct..0 =
(..= >
[// 
	FromQuery// 
]// 
int// 
id// 
,// 
[00 
FromServices00 
]00 
IHandler00 #
<00# $ 
ProductDeleteCommand00$ 8
>008 9
handler00: A
)00A B
{11 	
var22 
command22 
=22 
new22  
ProductDeleteCommand22 2
(222 3
id223 5
)225 6
;226 7
return44 
(44  
GenericCommandResult44 (
)44( )
await44) .
handler44/ 6
.446 7
Handle447 =
(44= >
command44> E
)44E F
;44F G
}55 	
[99 	
HttpPut99	 
(99 
$str99 !
)99! "
]99" #
[:: 	
	Authorize::	 
(:: 
Roles:: 
=:: 
$str:: *
)::* +
]::+ ,
[;; 	 
ProducesResponseType;;	 
(;; 
typeof;; $
(;;$ %
bool;;% )
);;) *
,;;* +
$num;;, /
);;/ 0
];;0 1
public<< 
async<< 
Task<< 
<<<  
GenericCommandResult<< .
><<. /
UpdateProduct<<0 =
(<<= >
[== 
FromBody== 
]==  
ProductUpdateCommand== +
command==, 3
,==3 4
[>> 
FromServices>> 
]>> 
IHandler>> #
<>># $ 
ProductUpdateCommand>>$ 8
>>>8 9
handler>>: A
)>>A B
{?? 	
return@@ 
(@@  
GenericCommandResult@@ (
)@@( )
await@@) .
handler@@/ 6
.@@6 7
Handle@@7 =
(@@= >
command@@> E
)@@E F
;@@F G
}AA 	
[EE 	
HttpGetEE	 
(EE 
$strEE "
)EE" #
]EE# $
[FF 	
AllowAnonymousFF	 
]FF 
[GG 	 
ProducesResponseTypeGG	 
(GG 
typeofGG $
(GG$ %
IListGG% *
<GG* +
ProductGG+ 2
>GG2 3
)GG3 4
,GG4 5
$numGG6 9
)GG9 :
]GG: ;
publicHH 
asyncHH 
TaskHH 
<HH 
IListHH 
<HH  
ProductHH  '
>HH' (
>HH( )
FindAllProductHH* 8
(HH8 9
[II 
FromServicesII 
]II 
IProductRepositoryII -

repositoryII. 8
)II8 9
{JJ 	
varKK 
resultKK 
=KK 
awaitKK 

repositoryKK )
.KK) *
FindAllKK* 1
(KK1 2
)KK2 3
;KK3 4
returnMM 
resultMM 
;MM 
}NN 	
[PP 	
HttpGetPP	 
(PP 
$strPP #
)PP# $
]PP$ %
[QQ 	
AllowAnonymousQQ	 
]QQ 
[RR 	 
ProducesResponseTypeRR	 
(RR 
typeofRR $
(RR$ %
ProductRR% ,
)RR, -
,RR- .
$numRR/ 2
)RR2 3
]RR3 4
publicSS 
asyncSS 
TaskSS 
<SS 
ProductSS !
>SS! "
FindByIdSS# +
(SS+ ,
[TT 
	FromQueryTT 
]TT 
intTT 
idTT 
,TT 
[UU 
FromServicesUU 
]UU 
IProductRepositoryUU -

repositoryUU. 8
)UU8 9
{VV 	
varWW 
resultWW 
=WW 
awaitWW 

repositoryWW )
.WW) *
FindByIdWW* 2
(WW2 3
idWW3 5
)WW5 6
;WW6 7
returnYY 
resultYY 
;YY 
}ZZ 	
[^^ 	
HttpGet^^	 
(^^ 
$str^^ +
)^^+ ,
]^^, -
[__ 	
AllowAnonymous__	 
]__ 
[`` 	 
ProducesResponseType``	 
(`` 
typeof`` $
(``$ %
Product``% ,
)``, -
,``- .
$num``/ 2
)``2 3
]``3 4
publicaa 
asyncaa 
Taskaa 
<aa 
IListaa 
<aa  
Productaa  '
>aa' (
>aa( )
FindByParametersaa* :
(aa: ;
[bb 
	FromQuerybb 
]bb 
intbb 

categoryIdbb &
,bb& '
[cc 
	FromQuerycc 
]cc 
intcc 
manufacturerIdcc *
,cc* +
[dd 
	FromQuerydd 
]dd 
intdd 
characteristicIddd ,
,dd, -
[ee 
	FromQueryee 
]ee 
stringee 
keyee "
,ee" #
[ff 
	FromQueryff 
]ff 
stringff 
keyDescriptionff -
,ff- .
[gg 
	FromQuerygg 
]gg 
stringgg 
descriptiongg *
,gg* +
[hh 
FromServiceshh 
]hh 
IProductRepositoryhh -

repositoryhh. 8
)hh8 9
{ii 	
varjj 
resultjj 
=jj 
awaitjj 

repositoryjj )
.jj) *
FindByParametersjj* :
(jj: ;

categoryIdjj; E
,jjE F
manufacturerIdkkE S
,kkS T
characteristicIdllE U
,llU V
keymmE H
,mmH I
keyDescriptionnnE S
,nnS T
descriptionooE P
)ooP Q
;ooQ R
returnqq 
resultqq 
;qq 
}rr 	
}ss 
}tt Á3
aD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Api\Controllers\UserController.cs
	namespace		 	
ComparaItens		
 
.		 
Api		 
.		 
Controllers		 &
{

 
[ 
ApiController 
] 
[ 
Route 

(
 
$str 
) 
] 
public 

class 
UserController 
:  !
ControllerBase" 0
{ 
[ 	
HttpPost	 
( 
$str 
)  
]  !
[ 	 
ProducesResponseType	 
( 
typeof $
($ %
bool% )
)) *
,* +
$num, /
)/ 0
]0 1
public 
async 
Task 
<  
GenericCommandResult .
>. /
PostUser0 8
(8 9
[ 
FromBody 
] 
UserInsertCommand (
command) 0
,0 1
[ 
FromServices 
] 
IHandler #
<# $
UserInsertCommand$ 5
>5 6
handler7 >
)> ?
{ 	
return 
(  
GenericCommandResult (
)( )
await) .
handler/ 6
.6 7
Handle7 =
(= >
command> E
)E F
;F G
} 	
[ 	

HttpDelete	 
( 
$str !
)! "
]" #
[ 	 
ProducesResponseType	 
( 
typeof $
($ %
bool% )
)) *
,* +
$num, /
)/ 0
]0 1
public   
async   
Task   
<    
GenericCommandResult   .
>  . /

DeleteUser  0 :
(  : ;
["" 
	FromQuery"" 
]"" 
int"" 
id"" 
,"" 
[## 
FromServices## 
]## 
IHandler## #
<### $
UserDeleteCommand##$ 5
>##5 6
handler##7 >
)##> ?
{$$ 	
var%% 
command%% 
=%% 
new%% 
UserDeleteCommand%% /
(%%/ 0
id%%0 2
)%%2 3
;%%3 4
return'' 
(''  
GenericCommandResult'' (
)''( )
await'') .
handler''/ 6
.''6 7
Handle''7 =
(''= >
command''> E
)''E F
;''F G
}(( 	
[,, 	
HttpPut,,	 
(,, 
$str,, 
),, 
],,  
[.. 	 
ProducesResponseType..	 
(.. 
typeof.. $
(..$ %
bool..% )
)..) *
,..* +
$num.., /
)../ 0
]..0 1
public// 
async// 
Task// 
<//  
GenericCommandResult// .
>//. /

UpdateUser//0 :
(//: ;
[00 
FromBody00 
]00 
UserUpdateCommand00 (
command00) 0
,000 1
[11 
FromServices11 
]11 
IHandler11 #
<11# $
UserUpdateCommand11$ 5
>115 6
handler117 >
)11> ?
{22 	
return33 
(33  
GenericCommandResult33 (
)33( )
await33) .
handler33/ 6
.336 7
Handle337 =
(33= >
command33> E
)33E F
;33F G
}44 	
[88 	
HttpGet88	 
(88 
$str88 
)88  
]88  !
[:: 	 
ProducesResponseType::	 
(:: 
typeof:: $
(::$ %
IList::% *
<::* +
User::+ /
>::/ 0
)::0 1
,::1 2
$num::3 6
)::6 7
]::7 8
public;; 
async;; 
Task;; 
<;; 
IList;; 
<;;  
User;;  $
>;;$ %
>;;% &
FindAllUser;;' 2
(;;2 3
[<< 
FromServices<< 
]<< 
IUserRepository<< *

repository<<+ 5
)<<5 6
{== 	
var>> 
result>> 
=>> 
await>> 

repository>> )
.>>) *
FindAll>>* 1
(>>1 2
)>>2 3
;>>3 4
return@@ 
result@@ 
;@@ 
}AA 	
[EE 	
HttpGetEE	 
(EE 
$strEE  
)EE  !
]EE! "
[GG 	 
ProducesResponseTypeGG	 
(GG 
typeofGG $
(GG$ %
IListGG% *
<GG* +
UserGG+ /
>GG/ 0
)GG0 1
,GG1 2
$numGG3 6
)GG6 7
]GG7 8
publicHH 
asyncHH 
TaskHH 
<HH 
UserHH 
>HH 
FindByIdUserHH  ,
(HH, -
[II 
	FromQueryII 
]II 
intII 
idII 
,II 
[JJ 
FromServicesJJ 
]JJ 
IUserRepositoryJJ *

repositoryJJ+ 5
)JJ5 6
{KK 	
varLL 
resultLL 
=LL 
awaitLL 

repositoryLL )
.LL) *
FindByIdLL* 2
(LL2 3
idLL3 5
)LL5 6
;LL6 7
returnNN 
resultNN 
;NN 
}OO 	
[SS 	
HttpPostSS	 
(SS 
$strSS %
)SS% &
]SS& '
[UU 	 
ProducesResponseTypeUU	 
(UU 
typeofUU $
(UU$ %
UserUU% )
)UU) *
,UU* +
$numUU, /
)UU/ 0
]UU0 1
publicVV 
asyncVV 
TaskVV 
<VV  
GenericCommandResultVV .
>VV. /
ValidateAccessVV0 >
(VV> ?
[WW 
FromBodyWW 
]WW %
UserValidateAccessCommandWW 0
commandWW1 8
,WW8 9
[XX 
FromServicesXX 
]XX 
IHandlerXX #
<XX# $%
UserValidateAccessCommandXX$ =
>XX= >
handlerXX? F
)YY 
{ZZ 	
return[[ 
([[  
GenericCommandResult[[ (
)[[( )
await[[) .
handler[[/ 6
.[[6 7
Handle[[7 =
([[= >
command[[> E
)[[E F
;[[F G
}\\ 	
}]] 
}^^ Â3
iD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Api\DependencyMap\HandlerDependencyMap.cs
	namespace 	
ComparaItens
 
. 
Api 
. 
DependencyMap (
{ 
public		 

static		 
class		  
HandlerDependencyMap		 ,
{

 
public 
static 
void 

HandlerMap %
(% &
this& *
IServiceCollection+ =
services> F
)F G
{ 	
services 
. 
	AddScoped 
< 
IHandler '
<' (!
CategoryInsertCommand( =
>= >
,> ?
CategoryHandler@ O
>O P
(P Q
)Q R
;R S
services 
. 
	AddScoped 
< 
IHandler '
<' (!
CategoryDeleteCommand( =
>= >
,> ?
CategoryHandler@ O
>O P
(P Q
)Q R
;R S
services 
. 
	AddScoped 
< 
IHandler '
<' (!
CategoryUpdateCommand( =
>= >
,> ?
CategoryHandler@ O
>O P
(P Q
)Q R
;R S
services 
. 
	AddScoped 
< 
IHandler '
<' ( 
ProductInsertCommand( <
>< =
,= >
ProductHandler? M
>M N
(N O
)O P
;P Q
services 
. 
	AddScoped 
< 
IHandler '
<' ( 
ProductDeleteCommand( <
>< =
,= >
ProductHandler? M
>M N
(N O
)O P
;P Q
services 
. 
	AddScoped 
< 
IHandler '
<' ( 
ProductUpdateCommand( <
>< =
,= >
ProductHandler? M
>M N
(N O
)O P
;P Q
services 
. 
	AddScoped 
< 
IHandler '
<' (%
ManufacturerInsertCommand( A
>A B
,B C
ManufacturerHandlerD W
>W X
(X Y
)Y Z
;Z [
services 
. 
	AddScoped 
< 
IHandler '
<' (%
ManufacturerDeleteCommand( A
>A B
,B C
ManufacturerHandlerD W
>W X
(X Y
)Y Z
;Z [
services 
. 
	AddScoped 
< 
IHandler '
<' (%
ManufacturerUpdateCommand( A
>A B
,B C
ManufacturerHandlerD W
>W X
(X Y
)Y Z
;Z [
services 
. 
	AddScoped 
< 
IHandler '
<' (
UserInsertCommand( 9
>9 :
,: ;
UserHandler< G
>G H
(H I
)I J
;J K
services 
. 
	AddScoped 
< 
IHandler '
<' (
UserUpdateCommand( 9
>9 :
,: ;
UserHandler< G
>G H
(H I
)I J
;J K
services 
. 
	AddScoped 
< 
IHandler '
<' (
UserDeleteCommand( 9
>9 :
,: ;
UserHandler< G
>G H
(H I
)I J
;J K
services   
.   
	AddScoped   
<   
IHandler   '
<  ' (%
UserValidateAccessCommand  ( A
>  A B
,  B C
UserHandler  D O
>  O P
(  P Q
)  Q R
;  R S
services## 
.## 
	AddScoped## 
<## 
IHandler## '
<##' ('
CharacteristicInsertCommand##( C
>##C D
,##D E!
CharacteristicHandler##F [
>##[ \
(##\ ]
)##] ^
;##^ _
services$$ 
.$$ 
	AddScoped$$ 
<$$ 
IHandler$$ '
<$$' ('
CharacteristicDeleteCommand$$( C
>$$C D
,$$D E!
CharacteristicHandler$$F [
>$$[ \
($$\ ]
)$$] ^
;$$^ _
services%% 
.%% 
	AddScoped%% 
<%% 
IHandler%% '
<%%' ('
CharacteristicUpdateCommand%%( C
>%%C D
,%%D E!
CharacteristicHandler%%F [
>%%[ \
(%%\ ]
)%%] ^
;%%^ _
services(( 
.(( 
	AddScoped(( 
<(( 
IHandler(( '
<((' (*
CharacteristicKeyInsertCommand((( F
>((F G
,((G H$
CharacteristicKeyHandler((I a
>((a b
(((b c
)((c d
;((d e
services)) 
.)) 
	AddScoped)) 
<)) 
IHandler)) '
<))' (*
CharacteristicKeyDeleteCommand))( F
>))F G
,))G H$
CharacteristicKeyHandler))I a
>))a b
())b c
)))c d
;))d e
services** 
.** 
	AddScoped** 
<** 
IHandler** '
<**' (*
CharacteristicKeyUpdateCommand**( F
>**F G
,**G H$
CharacteristicKeyHandler**I a
>**a b
(**b c
)**c d
;**d e
services-- 
.-- 
	AddScoped-- 
<-- 
IHandler-- '
<--' (2
&CharacteristicDescriptionInsertCommand--( N
>--N O
,--O P,
 CharacteristicDescriptionHandler--Q q
>--q r
(--r s
)--s t
;--t u
services.. 
... 
	AddScoped.. 
<.. 
IHandler.. '
<..' (2
&CharacteristicDescriptionDeleteCommand..( N
>..N O
,..O P,
 CharacteristicDescriptionHandler..Q q
>..q r
(..r s
)..s t
;..t u
services// 
.// 
	AddScoped// 
<// 
IHandler// '
<//' (2
&CharacteristicDescriptionUpdateCommand//( N
>//N O
,//O P,
 CharacteristicDescriptionHandler//Q q
>//q r
(//r s
)//s t
;//t u
}00 	
}11 
}22 ƒ
lD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Api\DependencyMap\RepositoryDependencyMap.cs
	namespace 	
ComparaItens
 
. 
Api 
. 
DependencyMap (
{ 
public 

static 
class #
RepositoryDependencyMap /
{ 
public		 
static		 
void		 
RepositoryMap		 (
(		( )
this		) -
IServiceCollection		. @
services		A I
)		I J
{

 	
services 
. 
	AddScoped 
< 
ICudRepository -
,- .
CudRepository/ <
>< =
(= >
)> ?
;? @
services 
. 
	AddScoped 
< 
ICategoryRepository 2
,2 3
CategoryRepository4 F
>F G
(G H
)H I
;I J
services 
. 
	AddScoped 
< 
IProductRepository 1
,1 2
ProductRepository3 D
>D E
(E F
)F G
;G H
services 
. 
	AddScoped 
< #
IManufacturerRepository 6
,6 7"
ManufacturerRepository8 N
>N O
(O P
)P Q
;Q R
services 
. 
	AddScoped 
< 
IUserRepository .
,. /
UserRepository0 >
>> ?
(? @
)@ A
;A B
services 
. 
	AddScoped 
< %
ICharacteristicRepository 8
,8 9$
CharacteristicRepository: R
>R S
(S T
)T U
;U V
services 
. 
	AddScoped 
< (
ICharacteristicKeyRepository ;
,; <'
CharacteristicKeyRepository= X
>X Y
(Y Z
)Z [
;[ \
services 
. 
	AddScoped 
< 0
$ICharacteristicDescriptionRepository C
,C D/
#CharacteristicDescriptionRepositoryE h
>h i
(i j
)j k
;k l
} 	
} 
} ï
iD:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Api\DependencyMap\ServiceDependencyMap.cs
	namespace 	
ComparaItens
 
. 
Api 
. 
DependencyMap (
{ 
public 

static 
class  
ServiceDependencyMap ,
{ 
public 
static 
void 

ServiceMap %
(% &
this& *
IServiceCollection+ =
services> F
,F G
IConfigurationH V
configurationW d
)d e
{		 	
} 	
} 
} ò
ND:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Api\Program.cs
	namespace 	
ComparaItens
 
. 
Api 
{ 
public 

class 
Program 
{ 
public 
static 
void 
Main 
(  
string  &
[& '
]' (
args) -
)- .
{		 	
CreateHostBuilder

 
(

 
args

 "
)

" #
.

# $
Build

$ )
(

) *
)

* +
.

+ ,
Run

, /
(

/ 0
)

0 1
;

1 2
} 	
	protected 
Program 
( 
) 
{ 	
} 	
public 
static 
IHostBuilder "
CreateHostBuilder# 4
(4 5
string5 ;
[; <
]< =
args> B
)B C
=>D F
Host 
.  
CreateDefaultBuilder %
(% &
args& *
)* +
. $
ConfigureWebHostDefaults )
() *

webBuilder* 4
=>5 7
{ 

webBuilder 
. 

UseStartup )
<) *
Startup* 1
>1 2
(2 3
)3 4
;4 5

webBuilder 
. 
UseIIS %
(% &
)& '
;' (
} 
) 
; 
} 
} ê:
ND:\Beto\Projetos\Isamar\Fontes\BuscaItens\Back\src\ComparaItens.Api\Startup.cs
	namespace 	
ComparaItens
 
. 
Api 
{ 
public 

class 
Startup 
{ 
public 
Startup 
( 
IConfiguration %
configuration& 3
)3 4
{ 	
Configuration 
= 
configuration )
;) *
} 	
public 
IConfiguration 
Configuration +
{, -
get. 1
;1 2
}3 4
public 
void 
ConfigureServices %
(% &
IServiceCollection& 8
services9 A
)A B
{   	
services"" 
."" 
RepositoryMap"" "
(""" #
)""# $
;""$ %
services## 
.## 

HandlerMap## 
(##  
)##  !
;##! "
services'' 
.'' 
AddDbContext'' !
<''! "
DataContext''" -
>''- .
(''. /
opt''/ 2
=>''3 5
opt''6 9
.''9 :
UseMySql'': B
(''B C
Configuration''C P
.''P Q
GetConnectionString''Q d
(''d e
$str''e l
)''l m
,''m n
new(( 
MySqlServerVersion(( &
(((& '
new((' *
Version((+ 2
(((2 3
$num((3 4
,((4 5
$num((6 7
,((7 8
$num((9 ;
)((; <
)((< =
)((= >
)((> ?
;((? @
services++ 
.++ 
AddCors++ 
(++ 
)++ 
;++ 
services,, 
.,, 
AddControllers,, #
(,,# $
),,$ %
;,,% &
var.. 
key.. 
=.. 
Encoding.. 
... 
ASCII.. $
...$ %
GetBytes..% -
(..- .
Settings... 6
...6 7
Secret..7 =
)..= >
;..> ?
services// 
.// 
AddAuthentication// &
(//& '
x//' (
=>//) +
{00 
x11 
.11 %
DefaultAuthenticateScheme11 +
=11, -
JwtBearerDefaults11. ?
.11? @ 
AuthenticationScheme11@ T
;11T U
x22 
.22 "
DefaultChallengeScheme22 (
=22) *
JwtBearerDefaults22+ <
.22< = 
AuthenticationScheme22= Q
;22Q R
}33 
)33 
.44 
AddJwtBearer44 
(44 
x44 
=>44 
{55 
x66 
.66  
RequireHttpsMetadata66 &
=66' (
false66) .
;66. /
x77 
.77 
	SaveToken77 
=77 
false77 #
;77# $
x88 
.88 %
TokenValidationParameters88 +
=88, -
new88. 1%
TokenValidationParameters882 K
{99 $
ValidateIssuerSigningKey:: ,
=::- .
true::/ 3
,::3 4
IssuerSigningKey;; $
=;;% &
new;;' * 
SymmetricSecurityKey;;+ ?
(;;? @
key;;@ C
);;C D
,;;D E
ValidateIssuer<< "
=<<# $
false<<% *
,<<* +
ValidateAudience== $
===% &
false==' ,
}>> 
;>> 
}?? 
)?? 
;?? 
servicesAA 
.AA 
AddSwaggerGenAA "
(AA" #
cAA# $
=>AA% '
{BB 
cCC 
.CC 

SwaggerDocCC 
(CC 
$strCC !
,CC! "
newCC# &
OpenApiInfoCC' 2
{CC3 4
TitleCC5 :
=CC; <
$strCC= O
,CCO P
VersionCCQ X
=CCY Z
$strCC[ _
}CC` a
)CCa b
;CCb c
cFF 
.FF !
AddSecurityDefinitionFF '
(FF' (
$strFF( 0
,FF0 1
newFF2 5!
OpenApiSecuritySchemeFF6 K
{GG 
DescriptionHH 
=HH  !
$str	II ø
,
IIø ¿
NameJJ 
=JJ 
$strJJ *
,JJ* +
InKK 
=KK 
ParameterLocationKK *
.KK* +
HeaderKK+ 1
,KK1 2
TypeLL 
=LL 
SecuritySchemeTypeLL -
.LL- .
ApiKeyLL. 4
,LL4 5
SchemeMM 
=MM 
$strMM %
}NN 
)NN 
;NN 
cPP 
.PP "
AddSecurityRequirementPP (
(PP( )
newPP) ,&
OpenApiSecurityRequirementPP- G
(PPG H
)PPH I
{QQ 
{RR 
newSS !
OpenApiSecuritySchemeSS )
{TT 
	ReferenceUU 
=UU 
newUU 
OpenApiReferenceUU  0
{VV 
TypeWW 
=WW 
ReferenceTypeWW $
.WW$ %
SecuritySchemeWW% 3
,WW3 4
IdXX 
=XX 
$strXX 
}YY 
,YY 
SchemeZZ 
=ZZ 
$strZZ !
,ZZ! "
Name[[ 
=[[ 
$str[[ 
,[[  
In\\ 
=\\ 
ParameterLocation\\ &
.\\& '
Header\\' -
,\\- .
}]] 
,]] 
new^^ 
List^^ 
<^^ 
string^^ 
>^^  
(^^  !
)^^! "
}__ 
}`` 
)`` 
;`` 
}bb 
)bb 
;bb 
}cc 	
publicff 
voidff 
	Configureff 
(ff 
IApplicationBuilderff 1
appff2 5
,ff5 6
IWebHostEnvironmentff7 J
envffK N
)ffN O
{gg 	
apphh 
.hh 
UseHttpsRedirectionhh #
(hh# $
)hh$ %
;hh% &
appjj 
.jj 

UseRoutingjj 
(jj 
)jj 
;jj 
appll 
.ll 
UseCorsll 
(ll 
xll 
=>ll 
xll 
.mm 
AllowAnyOriginmm 
(mm 
)mm  
.nn 
AllowAnyMethodnn 
(nn 
)nn  
.oo 
AllowAnyHeaderoo 
(oo 
)oo  
)oo  !
;oo! "
appqq 
.qq 
UseAuthenticationqq !
(qq! "
)qq" #
;qq# $
apprr 
.rr 
UseAuthorizationrr  
(rr  !
)rr! "
;rr" #
apptt 
.tt 
UseEndpointstt 
(tt 
	endpointstt &
=>tt' )
{uu 
	endpointsvv 
.vv 
MapControllersvv (
(vv( )
)vv) *
;vv* +
}ww 
)ww 
;ww 
appyy 
.yy 

UseSwaggeryy 
(yy 
)yy 
;yy 
appzz 
.zz 
UseSwaggerUIzz 
(zz 
czz 
=>zz !
czz" #
.zz# $
SwaggerEndpointzz$ 3
(zz3 4
$strzz4 N
,zzN O
$strzzP e
)zze f
)zzf g
;zzg h
}|| 	
}}} 
}~~ 