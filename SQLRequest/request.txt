Select P.name as product, C.name as category
from product as P
left join productcategory as PC on P.Id=PC.productId
left join category C on C.Id = PC.categoryId