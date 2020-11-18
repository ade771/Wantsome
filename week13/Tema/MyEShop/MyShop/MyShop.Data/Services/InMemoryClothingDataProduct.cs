using MyShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;

namespace MyShop.Data.Services
{
    public class InMemoryClothingDataProduct : IClothingData<Product>
    {
        public List<Product> products;


        public InMemoryClothingDataProduct()
        {

            products = new List<Product> {
                    new Product { Product_id = 1, Name = "Light brown leather belt", Description = "Belt with embossed metallic buckle", Category_id = 1, Subcategory_id = 1, Type_id = 16},
                    new Product { Product_id = 2, Name = "Dark brown leather belt", Description = "Belt with sports buckle and metallic feature on the tip", Category_id = 1, Subcategory_id = 1, Type_id = 16},
                    new Product { Product_id = 3, Name = "Metal bracelet", Description = "Metal cuff bracelet", Category_id = 1, Subcategory_id = 1, Type_id = 3 },
                    new Product { Product_id = 4, Name = "Birdseye suit blazer", Description = "Textured weave blazer with a notched lapel collar and a contrasting pin detail in the buttonhole. Features two front flap pockets, one besom pocket at the chest with a pocket square detail, lining with double inside pockets, double back vents, buttoned cuffs and button fastening in the front.", Category_id = 1, Subcategory_id = 3, Type_id = 19 },
                    new Product { Product_id = 5, Name = "Cropped loose fit jeans", Description = "Cropped faded loose fit jeans with ripped detailing. They feature two side pockets, two back pockets, one coin pocket, belt loops, button fly fastening in the front and frayed hems", Category_id = 1, Subcategory_id = 5, Type_id = 22},
                    new Product { Product_id = 6, Name = "Leather and jute espadrilles", Description = "Espadrilles with a leather upper and a natural jute sole", Category_id = 1, Subcategory_id = 7, Type_id = 26},
                    new Product { Product_id = 7, Name = "White embossed plimsolls", Description = "White plimsolls. Seven-eyelet facing. Embossed detailing on the upper, except for the toe cap and the heel. White soles", Category_id = 1, Subcategory_id = 7, Type_id = 12 },
                    new Product { Product_id = 8, Name = "Floral and swirl printed tank top", Description = "Sleeveless printed T-shirt with a round neckline. Features a chest pocket", Category_id = 1, Subcategory_id = 9, Type_id = 15 },
                    new Product { Product_id = 9, Name = "Texture striped t-shirt", Description = "Straight, printed T-shirt with a round neckline and short sleeves", Category_id = 1, Subcategory_id = 9, Type_id = 29},
                    new Product {Product_id = 10, Name = "Classic Cap", Description = "Cap", Category_id = 1, Subcategory_id = 1, Type_id = 31},
                    new Product {Product_id = 11, Name = "Colorful Round Shape Sunglasses", Description = "Colorful Round Shape Sunglasses", Category_id = 1, Subcategory_id =1, Type_id = 17},
                    new Product {Product_id = 12, Name = "Classic Square Shape Sunglasses ", Description = "Classic Square Shape Sunglasses ", Category_id = 1, Subcategory_id =1, Type_id = 17},
                    new Product {Product_id = 13, Name = "Blue Filter Sunglasses", Description ="Blue Filter Sunglasses", Category_id = 1, Subcategory_id = 1, Type_id = 17},
                    new Product {Product_id = 14, Name = "Yellow Backpack", Description ="Leather Yellow Backpack", Category_id =1, Subcategory_id = 2, Type_id =23},
                    new Product {Product_id = 15, Name = "Black Backpack", Description =" Leather Classic Black Backpack", Category_id =1, Subcategory_id = 2, Type_id =23},
                    new Product {Product_id = 16, Name ="White Checked Blazer", Description = "White Checked Blazer", Category_id = 1, Subcategory_id = 3, Type_id = 18},
                    new Product {Product_id = 17, Name = "Plain Blazer", Description = "Plain Blazer",Category_id = 1, Subcategory_id = 3, Type_id =7 },
                    new Product {Product_id = 18, Name = "Colorful Bomber Jacket", Description = "Colorful Bomber Jacket", Category_id = 1, Subcategory_id = 4, Type_id =20},
                    new Product {Product_id = 19, Name = "Denim Jacket", Description = "Jacket", Category_id = 1, Subcategory_id = 4, Type_id = 21},
                    new Product{Product_id = 20, Name = "Leather Jacket", Description ="Leather Jacket", Category_id =1, Subcategory_id =4, Type_id =23},
                    new Product {Product_id = 21, Name = "Slim Fit Jeans", Description = "Slim Fit Jeans", Category_id = 1, Subcategory_id = 5, Type_id =24},
                    new Product {Product_id = 22, Name = "Demim Shirt", Description = "Demim Shirt", Category_id = 1, Subcategory_id = 6, Type_id = 21},
                    new Product{Product_id = 23, Name = "Plain Shirt", Description = "Pink plain shirt", Category_id = 1, Subcategory_id = 6, Type_id = 7},
                    new Product{Product_id = 24, Name = "Leather Shoes", Description ="Clasic light brown leather shoes", Category_id = 1, Subcategory_id = 7, Type_id  = 23},
                    new Product{Product_id = 25, Name = "Plain T-shirts", Description = "Plain T-shirts", Category_id = 1, Subcategory_id = 9, Type_id = 7},
                    new Product{Product_id = 26, Name = "Floral T-shirt", Description = "Floral T-shirt", Category_id = 1, Subcategory_id = 9, Type_id =30},
                    new Product{Product_id = 27, Name = "Multicolor T-shirt", Description = "Multicolor T-shirt", Category_id = 1, Subcategory_id = 9, Type_id = 30},
                    new Product{Product_id =28, Name  ="Trunks Underwear", Description = "Trunks Underwear" , Category_id = 1, Subcategory_id = 10, Type_id = null},
                    new Product{Product_id =29, Name  ="Briefs Underwear", Description = "Briefs Underwear" , Category_id = 1, Subcategory_id = 10, Type_id = null},
                    new Product { Product_id = 30, Name = "Multicolored sequinned crossbody bag", Description = "Multicoloured mini crossbody bag. Multicoloured sequin appliqués on the exterior. Lined interior with pocket", Category_id = 2, Subcategory_id = 11, Type_id = 4 },
                    new Product { Product_id = 31, Name = "Lace bodysuit", Description = "Semi-sheer, strappy bodysuit with a V-neckline and snap button fastening on the bottom", Category_id = 2, Subcategory_id = 12, Type_id = 6 },
                    new Product { Product_id = 32, Name = "Long dress", Description = "Long red dress", Category_id = 2, Subcategory_id = 13, Type_id = 8 },
                    new Product { Product_id = 33, Name = "Midi White Dress", Description = "Long V-neck dress with short sleeves. ", Category_id = 2, Subcategory_id = 13, Type_id = 9},
                    new Product { Product_id = 34, Name = "Pleated waistcoat with inverted lapels", Description = "Double-breasted waistcoat with high inverted lapel collar. Box pleat detail on the hem in the same fabric. Features front flap pockets and button fastening", Category_id = 2, Subcategory_id = 13, Type_id = 4 },
                    new Product { Product_id = 35, Name = "Floral print short jumpsuit", Description = "Jumpsuit with an elastic neckline and short ruffled sleeves. Features a seam at the waist, a matching fabric belt, a ruffled hem and zip and button fastening in the front", Category_id = 2, Subcategory_id = 14, Type_id = null },
                    new Product { Product_id = 36, Name = "Fabric high-heel court shoes", Description = "Fuchsia high-heel shoes. Kitten heels. Pointed toes", Category_id = 2, Subcategory_id = 7, Type_id = 11 },
                    new Product {Product_id = 37, Name  = "Vintage Glasses", Description = "Pink vintage glasses", Category_id = 2, Subcategory_id = 1, Type_id = 1},
                    new Product {Product_id = 38, Name = "Clasic Glasses", Description = "Classic round black glasses", Category_id = 2, Subcategory_id = 1, Type_id = 1},
                    new Product {Product_id = 39, Name = "Vintage hat", Description ="Vintage hat", Category_id = 2, Subcategory_id = 1, Type_id = 2},
                    new Product{Product_id = 40, Name = "Dangle Earring", Description = "Dangle Earring", Category_id = 2, Subcategory_id = 1, Type_id = 3},
                    new Product {Product_id = 41, Name = "Vintage Earring", Description = "Blue stud earring", Category_id = 2, Subcategory_id = 1, Type_id = 3},
                    new Product{Product_id = 42, Name= "Hoop Earring", Description = "Hoop Earring", Category_id = 2, Subcategory_id = 1, Type_id = 3},
                    new Product {Product_id = 43, Name = "Bowling bag", Description = "Bowling bag", Category_id = 2, Subcategory_id = 11, Type_id = 5},
                    new Product {Product_id = 44, Name = "Shopping bag", Description = "Shopping bag", Category_id = 2, Subcategory_id = 11, Type_id = 5},
                    new Product {Product_id = 45, Name = "Tote bag", Description ="Red Tote Bag", Category_id = 2, Subcategory_id = 11, Type_id = 5},
                    new Product {Product_id = 46, Name = "Classic Mini bag", Description = "Black Mini bag", Category_id =2, Subcategory_id = 11, Type_id =4 },
                    new Product {Product_id = 47, Name = "Mini Weekend bag", Description = "Mini Weekend bag", Category_id = 2, Subcategory_id = 11, Type_id = 4},
                    new Product{Product_id = 48, Name =" Pink Slim fit Jeans", Description = " Pink Slim fit Jeans", Category_id = 2, Subcategory_id = 5, Type_id = 24},
                    new Product {Product_id = 49, Name ="Denim Slim fit Jeans", Description = "Denim Slim fit Jeans", Category_id = 2, Subcategory_id = 5, Type_id = 24},
                    new Product{Product_id = 50, Name = "Black Regular Fit Jeans", Description = "Black Regular Fit Jeans", Category_id = 2, Subcategory_id  = 5, Type_id =22},
                    new Product {Product_id = 51, Name = "Vintage Regular Fit Jeans", Description = "Vintage Regular Fit Jeans", Category_id = 2, Subcategory_id = 5, Type_id = 22},
                    new Product {Product_id = 52, Name = "Classic White Flats", Description = "Classic White Flats", Category_id = 2, Subcategory_id = 7, Type_id = 10},
                    new Product {Product_id = 53, Name = "Vintage Flats", Description = "Vintage Flats", Category_id = 2, Subcategory_id = 7, Type_id = 10},
                    new Product{Product_id = 54, Name = "Casual White Snekers", Description = "Casual White Snekers", Category_id = 2, Subcategory_id = 7, Type_id =12},
                    new Product {Product_id = 55, Name = "Slippers Shoes", Description = "Slippers Shoes", Category_id = 2, Subcategory_id = 7, Type_id = 13},
                    new Product {Product_id = 56, Name = "Bow Sandals", Description ="Bow Sandals", Category_id = 2, Subcategory_id = 7, Type_id = 13},
                    new Product {Product_id = 57, Name = " Pleated Purple Midi Skirt", Description = " Pleated Purple Midi Skirt", Category_id =2, Subcategory_id = 15, Type_id =9},
                    new Product{Product_id = 58, Name = "Vintage Midi Skirt", Description = "Vintage Midi Skirt", Category_id = 2, Subcategory_id = 15, Type_id = 9},
                    new Product{Product_id = 59, Name = "Floral Mini Skirt", Description ="Floral Mini Skirt", Category_id = 2, Subcategory_id = 15, Type_id =4},
                    new Product{Product_id = 60, Name = "Denim Mini Skirt", Description = "Denim Mini Skirt", Category_id =2, Subcategory_id =15, Type_id = 4},
                    new Product {Product_id= 61, Name = "Pink Mini Skirt", Description = "Pink Mini Skirt", Category_id = 2, Subcategory_id = 15, Type_id =4},
                    new Product{Product_id =62, Name = "Colorful Swimwear", Description = "Colorful Swimwear", Category_id =2, Subcategory_id =15, Type_id =null},
                    new Product{Product_id =63, Name ="Basic V-neck T-shirt", Description = "Basic V-neck T-shirt", Category_id = 2, Subcategory_id = 9, Type_id = 14},
                    new Product {Product_id = 64, Name ="Baic Crew- neck T-shirt",Description = "Baic Crew- neck T-shirt", Category_id = 2, Subcategory_id = 9, Type_id = 14 },
                    new Product {Product_id = 65, Name = "Printed T-shirt", Description ="Printed T-shirt", Category_id =2, Subcategory_id =9, Type_id = 30},
                    new Product {Product_id = 66, Name  = "Jewel Sleeveless T-shirt", Description = "Jewel Sleeveless T-shirt", Category_id =2, Subcategory_id =9, Type_id =15},
                    new Product {Product_id = 67, Name  = "Spaghetti Strap Sleeveless T-shirt", Description = "Spaghetti Strap Sleeveless T-shirt", Category_id =2, Subcategory_id =9, Type_id =15 },
                    new Product{Product_id = 68, Name = "Vintage Plain Body",  Description = "Vintage Plain Body", Category_id =2, Subcategory_id =12, Type_id =7},
                    new Product {Product_id = 69, Name = "Cool baby hat", Description ="Bucket hat with 'Monster Truck' print", Category_id = 3, Subcategory_id = 1, Type_id = 2 },
                    new Product {Product_id = 70, Name = "Superhero cap", Description = "Baseball cap with Iron Man style", Category_id = 3, Subcategory_id = 1, Type_id = 31},
                    new Product {Product_id = 71, Name = "Cowboy hat", Description = "Cowboy hat with blue star sheriff badge", Category_id = 3, Subcategory_id = 1, Type_id = 2},
                    new Product {Product_id = 72, Name = "Toddler baby hat", Description = "Cute baby white hat with hearts printed", Category_id = 3, Subcategory_id = 1, Type_id = 2},
                    new Product {Product_id = 73, Name = "Bowler hat", Description = "Classic black hat", Category_id = 3, Subcategory_id = 1, Type_id = 2},
                    new Product { Product_id = 74, Name = "Superman pendant necklace", Description = "Gold necklace with Superman sign", Category_id = 3, Subcategory_id = 1, Type_id = 3},
                    new Product { Product_id = 75, Name = "Naruto pendant", Description = "Metalic anime necklace with ninja sign", Category_id = 3, Subcategory_id = 1, Type_id = 3},
                    new Product { Product_id = 76, Name = "Silver bracelet", Description = "Black silver bracelet ", Category_id = 3, Subcategory_id = 1, Type_id = 3 },
                    new Product { Product_id = 77, Name = "Animal pendant", Description = "Animal pendant", Category_id = 3, Subcategory_id = 1, Type_id = 3},
                    new Product { Product_id = 78, Name = "Geometric bracelet", Description = "Geometric bracelet", Category_id = 3, Subcategory_id = 1, Type_id = 3 },
                    new Product { Product_id = 79, Name = "Retro round glasses", Description = "Classic glasses", Category_id = 3, Subcategory_id = 1, Type_id = 17},
                    new Product { Product_id = 80, Name = "Cartoon glasses", Description = "Fish flip up glasses", Category_id = 3, Subcategory_id = 1, Type_id = 17},
                    new Product { Product_id = 81, Name = "Foldable toddler glasses", Description = "Colorful glasses", Category_id = 3, Subcategory_id = 1, Type_id = 17},
                    new Product { Product_id = 82, Name = "Round sunglasses", Description = "Round yellow sunglasses", Category_id = 3, Subcategory_id = 1, Type_id = 17},
                    new Product { Product_id = 83, Name = "Spiderman glasses", Description = "Spiderman glasses", Category_id = 3, Subcategory_id = 1, Type_id = 17},
                    new Product {Product_id = 84, Name = "Denim Jacket", Description =  "Denim Jacket", Category_id = 3, Subcategory_id = 4, Type_id = 21},
                    new Product {Product_id = 85, Name = "Leather Jacket", Description = "Leather Jacket", Category_id = 3, Subcategory_id = 4, Type_id = 23},
                    new Product { Product_id =86, Name = "Bomber Jacket", Description = " Green Bomber Jacket", Category_id = 3, Subcategory_id = 4, Type_id= 20},
                    new Product {Product_id = 87, Name = "Padded Bomber Jacket", Description =" Blue Bomber Jacket", Category_id = 3, Subcategory_id =4, Type_id = 20},
                    new Product {Product_id= 88, Name = "Iron Man Jacket", Description = "Bomber Jacket with Iron Man Marvel printed", Category_id = 3, Subcategory_id = 4, Type_id = 20},
                    new Product {Product_id = 89, Name = "Denim Jeans", Description = "Slim fit jeans", Category_id =3, Subcategory_id = 5, Type_id = 24 },
                    new Product {Product_id = 90, Name = "Spider-Man Denim Jeans", Description = "Slim fit jeans for boys with Spider-Man printed", Category_id = 3, Subcategory_id = 5 ,Type_id= 24},
                    new Product {Product_id = 91, Name = "Casual Denim Jeans", Description = "Casual Slim fit", Category_id = 3, Subcategory_id = 5, Type_id = 24},
                    new Product {Product_id = 92, Name = "Winter pants Jeans", Description = "Winter pants", Category_id = 3,Subcategory_id = 5, Type_id =22},
                    new Product {Product_id = 93, Name = "Soft Trousers Denim", Description = "Slim fit Jeans", Category_id =3, Subcategory_id = 5, Type_id = 24},
                    new Product {Product_id = 94, Name = "Dinosaur T-shirt", Description = "Dinosaur graphic printed T-shirt", Category_id = 3, Subcategory_id = 9, Type_id = 30},
                    new Product {Product_id = 95, Name ="Cartoon Printed T-shirt", Description = "Cute elephant printed", Category_id = 3, Subcategory_id = 9, Type_id = 30},
                    new Product {Product_id = 96, Name = "Cartoon Printed Toddler Boys", Description = "Colorful animal printed", Category_id = 3, Subcategory_id = 9 , Type_id =30 },
                    new Product {Product_id = 97, Name ="Plant vs. Zombies cartoon children", Description ="Printed T-shirt with plant cartoon", Category_id =3, Subcategory_id =9, Type_id =30},
                    new Product {Product_id = 98, Name ="Spider-Man T-shirt", Description = "Spider-Man T-shirt", Category_id = 3, Subcategory_id =9, Type_id = 30},
                    new Product{Product_id = 99, Name = "Shark button front Tshirt", Description = "Shark button front Tshirt", Category_id =3, Subcategory_id = 9, Type_id =30},
                    new Product {Product_id =100, Name = "Cartoon Sneakers", Description = "Sneakers cartoon printed", Category_id =3, Subcategory_id = 7, Type_id =12},
                    new Product{Product_id = 101, Name = " Faster Trainer shoes", Description ="Blue Sneakers with cartoon printed", Category_id =3, Subcategory_id =7,Type_id =12},
                    new Product {Product_id =102, Name ="Soft Snekers Shoes", Description = "Colorful Casual Snekers", Category_id =3, Subcategory_id = 7, Type_id = 12},
                    new Product {Product_id =103, Name ="Casual Sneakers", Description ="Spider-Man Shoes with led lights", Category_id = 3, Subcategory_id = 7, Type_id = 25},
                    new Product {Product_id =104, Name = "Led lights wings shoes", Description ="Snekers with wings", Category_id =3, Subcategory_id = 7, Type_id = 12},
                    new Product {Product_id =105, Name = "Classic short", Description ="Blue logo short", Category_id = 3, Subcategory_id = 17, Type_id = null},
                    new Product {Product_id =106, Name ="Summer beach short", Description ="Boys blue shorts wear for summer", Category_id =3, Subcategory_id =17, Type_id =null},
                    new Product {Product_id = 107, Name = "Chino Short", Description ="Casual short ", Category_id =3, Subcategory_id = 17, Type_id = null },
                    new Product {Product_id = 108, Name = "Denim Shorts", Description ="Cowboy denim shorts", Category_id =3, Subcategory_id =17, Type_id = null},
                    new Product {Product_id = 109, Name = "Bottom denim", Description = "Denim ripped short", Category_id = 3, Subcategory_id = 17, Type_id = null},
                    new Product {Product_id = 110, Name ="Classic Sunglasses", Description ="Solid Neon Pink", Category_id =3, Subcategory_id = 1, Type_id = 17},
                    new Product {Product_id = 111, Name = "Minnie Sunglasses", Description ="Disney Minnie Mouse Sunglasses", Category_id =3, Subcategory_id =1,Type_id =17},
                    new Product{ Product_id = 112, Name = "Love Sunglasses", Description ="Heart Shape Minnie Mouse", Category_id = 3, Subcategory_id = 1, Type_id = 17 },
                    new Product {Product_id =113, Name = "Cat Sunglasses", Description ="Bright Pink Cat Sunglasses", Category_id = 3, Subcategory_id = 1, Type_id =17},
                    new Product {Product_id = 114, Name = "Cartoon Sunglasses", Description = "Flower Shape Sunglasses", Category_id =3, Subcategory_id =1, Type_id =17},
                    new Product {Product_id = 115, Name = "Baseball girl cap", Description ="Pink cap", Category_id =3, Subcategory_id = 1, Type_id =31},
                    new Product {Product_id = 116, Name = "Cat cap", Description = "Cute pink cap with cat design", Category_id =3, Subcategory_id = 1, Type_id =31},
                    new Product{Product_id = 117, Name = "Sun hat", Description =" Baby girl pink sun hat", Category_id = 3, Subcategory_id = 1,Type_id =2},
                    new Product {Product_id =118, Name = "Floral sun hat", Description ="Soft Muslin Summer Rosses Sun Hat", Category_id =3,Subcategory_id =1, Type_id =2},
                    new Product{Product_id = 119, Name = "Rainbow hat", Description ="Multi colored bucked hat", Category_id =3, Subcategory_id = 1, Type_id = 2},
                    new Product {Product_id =120, Name ="Hello Kitty bracelet", Description ="Hello Kitty bracelet diamant bangle", Category_id = 3, Subcategory_id = 1, Type_id = 3},
                    new Product {Product_id =121, Name = "Pink Hair Clip", Description ="Glitter Shinning Bling Heart Hair Clip", Category_id = 3, Subcategory_id = 1, Type_id = 3},
                    new Product {Product_id =122, Name = "Cat HeadBand", Description ="Cat Ears Girl HeadBand", Category_id = 3, Subcategory_id = 1,Type_id= 3},
                    new Product {Product_id = 123, Name = "Pearl Bracelet", Description ="Blue Pearls bracelet", Category_id = 3, Subcategory_id = 1, Type_id = 3},
                    new Product {Product_id = 124, Name = "Little Princess Tutu Dress", Description = "Pink Midi Dress", Category_id =3, Subcategory_id = 13, Type_id = 9},
                    new Product {Product_id =125, Name = "Lace dress", Description = "Pink Tutu .Little maven girl", Category_id =3, Subcategory_id = 13, Type_id = 9},
                    new Product {Product_id = 126, Name = "Special occasion Dress", Description = "Pink Tutu dress", Category_id =3, Subcategory_id = 13, Type_id = 9 },
                    new Product {Product_id =127, Name = "Baby girl dress", Description ="Yellow dress with white flowers dress for baby girl", Category_id = 3,Subcategory_id = 13,Type_id =9},
                    new Product { Product_id =128, Name = "Cat dress",Description ="Cat pattern and butterfly tutu" ,Category_id =3, Subcategory_id = 13, Type_id = 9 },
                    new Product {Product_id  = 129, Name = "Casual Flowers Jacket",Description ="Cotton Flowers Jacket", Category_id = 3, Subcategory_id = 4,Type_id =20},
                    new Product {Product_id = 130, Name = "Pink Jacket", Description = "Flowers Print Jacket", Category_id =3, Subcategory_id =4, Type_id = 20},
                    new Product {Product_id = 131, Name = "Autumn Jacket", Description ="Blue long Jacket", Category_id = 3, Subcategory_id = 4, Type_id =20 },
                    new Product {Product_id =132, Name = "Denim Jacket with  tulle", Description= "Denim Jacket with white tulle", Category_id =3, Subcategory_id = 4, Type_id = 21},
                    new Product { Product_id = 133, Name = "Pink Leather Jacket", Description ="Pink Leather Jacket", Category_id = 3, Subcategory_id = 4, Type_id = 23},
                    new Product { Product_id = 134, Name = "Skinny Jeans", Description = "Casual Skinny Jeans", Category_id = 3, Subcategory_id = 5, Type_id = 24},
                    new Product {Product_id = 135, Name = "Distressed Skinny Jeans", Description = "Distressed Skinny Jeans", Category_id = 3, Subcategory_id = 5, Type_id =24},
                    new Product {Product_id = 136, Name = "Ripped Skinny Jeans", Description = "Ripped Skinny Jeans", Category_id = 3, Subcategory_id = 5, Type_id = 24},
                    new Product {Product_id = 137, Name= "Classic Skinny Jeans", Description = "Classic Skinny Jeans", Category_id = 3, Subcategory_id = 5, Type_id = 24},
                    new Product {Product_id = 138, Name = "Straight Ankle Jeans", Description = "Black Skinny Jeans", Category_id = 3, Subcategory_id = 5, Type_id =24},
                    new Product{Product_id = 139, Name = "Puffy Sneakers", Description = "Pink Sneakers for baby girls", Category_id = 3, Subcategory_id = 7, Type_id = 12},
                    new Product {Product_id = 140, Name = "Cartoon Sport Sneakers", Description = "Cartoon Sport Sneakers", Category_id = 3, Subcategory_id = 7, Type_id= 12},
                    new Product {Product_id = 141, Name = "Lovely Leather Shoes", Description = "Lovely Leather Shoes", Category_id = 3, Subcategory_id = 7, Type_id = 23},
                    new Product {Product_id = 142, Name = "Rose Flower Shoes", Description = "Rose Flower Shoes", Category_id = 3, Subcategory_id = 7,Type_id = 25},
                    new Product {Product_id = 143, Name = "Princess Flat Garden Shoes", Description = "Princess Flat Garden Shoes", Category_id = 3, Subcategory_id = 7, Type_id = 10},
                    new Product {Product_id = 144, Name = "Tutu Pink Skirt", Description = "Tutu Pink Skirt", Category_id = 3, Subcategory_id = 15, Type_id = 4},
                    new Product {Product_id = 145, Name = "Pink Skirt", Description = "Pink skirt with no pockets", Category_id = 3, Subcategory_id = 15 , Type_id = 9},
                    new Product {Product_id = 146, Name = "Light pink Skirt", Description = "Skirt for toddler", Category_id = 3, Subcategory_id = 15, Type_id = 4},
                    new Product {Product_id = 147, Name = "Colorful Tutu Skirt", Description = "Colorful Tutu Skirt", Category_id = 3, Subcategory_id = 15, Type_id = 4},
                    new Product {Product_id = 148, Name = "Denim Pleated Skirt", Description = "Denim Pleated Skirt", Category_id = 3, Subcategory_id = 15, Type_id = 4},


            };







        }


        public  void Add(Product product)
        {
            products.Add(product);
            product.Product_id = products.Max(p => p.Product_id) + 1;
        }

        public  void Delete(int id)
        {
            var product = Get(id);
            if (product != null)
            {
                products.Remove(product);
            }
        }

        public  Product Get(int id)
        {
            return products.FirstOrDefault(r => r.Product_id == id);
        }


        public  IEnumerable<Product> GetAll()
        {
            return products.OrderBy(r => r.Name);
        }

        public  void Update(Product product)
        {
            var existing = Get(product.Product_id);
            if (existing != null)
            {
                existing.Name = product.Name;

            }
        }
    }
}