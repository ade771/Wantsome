using MyShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyShop.Data.Services
{
    public class InMemoryClothingDataProductPhoto : IClothingData<ProductPhoto>
    {

        public List<ProductPhoto> productPhotos;

        public InMemoryClothingDataProductPhoto()
        {



            productPhotos = new List<ProductPhoto> {
                    new ProductPhoto { Photo_id = 1, Product_id = 1, Source = @"~/Content/images/MEN/Accessories/Belts/1_1.jpg", Alt = "Belt" },
                    new ProductPhoto { Photo_id = 2, Product_id = 2, Source = @"~/Content/images/MEN/Accessories/Belts/2_1.jpg", Alt = "Belt" },
                    new ProductPhoto {Photo_id = 3,Product_id = 3, Source = @"~/Content/images/MEN/Accessories/Jewellery/2_1.jpg", Alt = "Bracelet" },
                    new ProductPhoto {Photo_id = 4,Product_id = 4, Source = @"~/Content/images/MEN/Blazers/Vests/1_1.jpg", Alt = "Vest" },
                    new ProductPhoto {Photo_id = 5,Product_id = 5, Source = @"~/Content/images/MEN/Jeans/Regular_fit/1_1.jpg", Alt = "Jeans" },
                    new ProductPhoto {Photo_id = 6,Product_id = 6, Source = @"~/Content/images/MEN/Shoes/Moccasins/2_1.jpg", Alt = "Shoes" },
                    new ProductPhoto {Photo_id = 7,Product_id = 6, Source = @"~/Content/images/MEN/Shoes/Moccasins/1_1.jpg", Alt = "Shoes" },
                    new ProductPhoto {Photo_id = 8,Product_id = 7, Source = @"~/Content/images/MEN/Shoes/Sneakers/1_1.jpg", Alt = "Sneakers" },
                    new ProductPhoto {Photo_id = 9,Product_id = 7, Source = @"~/Content/images/MEN/Shoes/Sneakers/2_1.jpg", Alt = "Sneakers" },
                    new ProductPhoto {Photo_id = 10,Product_id =7, Source = @"~/Content/images/MEN/Shoes/Sneakers/3_1.jpg", Alt = "Sneakers" },
                    new ProductPhoto {Photo_id = 11,Product_id =8, Source = @"~/Content/images/MEN/TShirts/Sleeveless/2_1.jpg", Alt = "T-Shirt" },
                    new ProductPhoto {Photo_id = 12,Product_id = 9, Source = @"~/Content/images/MEN/TShirts/Striped/1_1.jpg", Alt = "T-Shirt" },
                    new ProductPhoto {Photo_id = 13,Product_id = 10, Source = @"~/Content/images/MEN/Accessories/Hats/1_1.jpg", Alt = "Caps" },
                    new ProductPhoto {Photo_id =14,Product_id = 10, Source = @"~/Content/images/MEN/Accessories/Hats/2_1.jpg", Alt = "Caps" },
                    new ProductPhoto {Photo_id =15,Product_id = 10, Source = @"~/Content/images/MEN/Accessories/Hats/3_1.jpg", Alt = "Caps" },
                    new ProductPhoto {Photo_id =16,Product_id = 11, Source = @"~/Content/images/MEN/Accessories/Sunglasses/1_1.jpg", Alt = "Sunglasses" },
                    new ProductPhoto {Photo_id =17,Product_id = 12, Source = @"~/Content/images/MEN/Accessories/Sunglasses/2_2.jpg", Alt = "Sunglasses" },
                    new ProductPhoto {Photo_id =18,Product_id = 13, Source = @"~/Content/images/MEN/Accessories/Sunglasses/3_2.jpg", Alt = "Sunglasses" },
                    new ProductPhoto{Photo_id = 19,Product_id = 14, Source =  @"~/Content/images/MEN/Backpacks/1_1.jpg", Alt ="Backpacks"},
                    new ProductPhoto {Photo_id = 20, Product_id =15, Source =  @"~/Content/images/MEN/Backpacks/2_1.jpg", Alt ="Backpacks"},
                    new ProductPhoto {Photo_id = 21, Product_id =16, Source =  @"~/Content/images/MEN/Blazers/Checked/1_1.jpg", Alt ="Blazers"},
                    new ProductPhoto {Photo_id = 22, Product_id =17, Source =  @"~/Content/images/MEN/Blazers/Plain/1_1.jpg", Alt ="Blazers"},
                    new ProductPhoto {Photo_id = 23, Product_id =17, Source = @"~/Content/images/MEN/Blazers/Plain/2_1.jpg", Alt ="Blazers"},
                    new ProductPhoto {Photo_id = 24, Product_id =18, Source = @"~/Content/images/MEN/Jackets/Bomber/1_1.jpg", Alt ="Jackets"},
                    new ProductPhoto {Photo_id = 25, Product_id =19, Source = @"~/Content/images/MEN/Jackets/Denim/1_1.jpg", Alt ="Jackets"},
                    new ProductPhoto {Photo_id = 26, Product_id =20, Source = @"~/Content/images/MEN/Jackets/Leather/1_1.jpg", Alt ="Jackets"},
                    new ProductPhoto {Photo_id = 27, Product_id =21, Source = @"~/Content/images/MEN/Jeans/Slim_fit/1_1.jpg", Alt ="Jeans"},
                    new ProductPhoto {Photo_id = 28, Product_id =21, Source = @"~/Content/images/MEN/Jeans/Slim_fit/3_1.jpg", Alt ="Jeans"},
                    new ProductPhoto {Photo_id = 29, Product_id =22, Source = @"~/Content/images/MEN/Shirts/Denim/1_1.jpg", Alt ="Shirt"},
                    new ProductPhoto {Photo_id = 30, Product_id =22, Source = @"~/Content/images/MEN/Shirts/Denim/2_1.jpg", Alt ="Shirt"},
                    new ProductPhoto {Photo_id = 31, Product_id =23, Source = @"~/Content/images/MEN/Shirts/Plain/1_1.jpg", Alt ="Shirt"},
                    new ProductPhoto {Photo_id = 32, Product_id =24, Source = @"~/Content/images/MEN/Shoes/Leather/1_1.jpg", Alt ="Shoes"},
                    new ProductPhoto {Photo_id = 33, Product_id =25, Source = @"~/Content/images/MEN/TShirts/Plain/1_1.jpg", Alt ="TShirt"},
                    new ProductPhoto {Photo_id = 34, Product_id =25, Source = @"~/Content/images/MEN/TShirts/Plain/2_1.jpg", Alt ="TShirt"},
                    new ProductPhoto {Photo_id = 35, Product_id =25, Source = @"~/Content/images/MEN/TShirts/Plain/3_1.jpg", Alt ="TShirt"},
                    new ProductPhoto {Photo_id = 36, Product_id =26, Source = @"~/Content/images/MEN/TShirts/Printed/1_1.jpg", Alt ="TShirt"},
                    new ProductPhoto {Photo_id = 37, Product_id =27, Source = @"~/Content/images/MEN/TShirts/Printed/3_1.jpg", Alt ="TShirt"},
                    new ProductPhoto {Photo_id = 38, Product_id =28, Source = @"~/Content/images/MEN/Underwear/3_1.jpg", Alt ="Underwear"},
                    new ProductPhoto {Photo_id = 39, Product_id =29, Source =  @"~/Content/images/MEN/Underwear/4_1.jpg", Alt ="Underwear"},
                    new ProductPhoto {Photo_id = 40, Product_id =30, Source =  @"~/Content/images/WOMEN/Bags/Mini_bags/1_1.jpg", Alt ="Mini Bags"},
                    new ProductPhoto {Photo_id = 41, Product_id =31, Source =  @"~/Content/images/WOMEN/Body/Lace/1_1.jpg", Alt ="Body"},
                    new ProductPhoto {Photo_id = 42, Product_id =32, Source =  @"~/Content/images/WOMEN/Dresses/Maxi/1_1.jpg", Alt ="Dresses"},
                    new ProductPhoto {Photo_id = 43, Product_id =33, Source =  @"~/Content/images/WOMEN/Dresses/Midi/1_3.jpg", Alt ="Dresses"},
                    new ProductPhoto {Photo_id = 44, Product_id =34, Source =  @"~/Content/images/WOMEN/Dresses/Mini/2_1.jpg", Alt ="Dresses"},
                    new ProductPhoto {Photo_id = 45, Product_id =35, Source =  @"~/Content/images/WOMEN/Jumpsuits/3_1.jpg", Alt ="Jumpsuits"},
                    new ProductPhoto {Photo_id = 46, Product_id =36, Source =  @"~/Content/images/WOMEN/Shoes/High_heels/2_1.jpg", Alt ="Shoes"},
                    new ProductPhoto {Photo_id = 47, Product_id =37, Source =  @"~/Content/images/WOMEN/Accessories/Eyewear/1_2.jpg", Alt ="Accessories"},
                    new ProductPhoto {Photo_id = 48, Product_id =38, Source = @"~/Content/images/WOMEN/Accessories/Eyewear/2_3.jpg", Alt ="Accessories"},
                    new ProductPhoto {Photo_id = 49, Product_id =39, Source = @"~/Content/images/WOMEN/Accessories/Hats/1_1.jpg", Alt ="Accessories"},
                    new ProductPhoto {Photo_id = 50, Product_id =39, Source = @"~/Content/images/WOMEN/Accessories/Hats/2_2.jpg", Alt ="Accessories"},
                    new ProductPhoto {Photo_id = 51, Product_id =40, Source = @"~/Content/images/WOMEN/Accessories/Jewellery/1_1.jpg", Alt ="Accessories"},
                    new ProductPhoto {Photo_id = 52, Product_id =41, Source = @"~/Content/images/WOMEN/Accessories/Jewellery/2_1.jpg", Alt ="Accessories"},
                    new ProductPhoto {Photo_id = 53, Product_id =42, Source = @"~/Content/images/WOMEN/Accessories/Jewellery/3_1.jpg", Alt ="Accessories"},
                    new ProductPhoto {Photo_id = 54, Product_id =43, Source = @"~/Content/images/WOMEN/Bags/Large_bags/1_1.jpg", Alt ="Bags"},
                    new ProductPhoto {Photo_id = 55, Product_id =44, Source = @"~/Content/images/WOMEN/Bags/Large_bags/2_1.jpg", Alt ="Bags"},
                    new ProductPhoto {Photo_id = 56, Product_id =45, Source = @"~/Content/images/WOMEN/Bags/Large_bags/3_1.jpg", Alt ="Bags"},
                    new ProductPhoto {Photo_id = 57, Product_id =46, Source = @"~/Content/images/WOMEN/Bags/Mini_bags/2_1.jpg", Alt ="Bags"},
                    new ProductPhoto {Photo_id = 58, Product_id =47, Source = @"~/Content/images/WOMEN/Bags/Mini_bags/3_1.jpg", Alt ="Bags"},
                    new ProductPhoto {Photo_id = 59, Product_id =48, Source = @"~/Content/images/WOMEN/Jeans/1_1.jpg", Alt ="Jeans"},
                    new ProductPhoto {Photo_id = 60, Product_id =49, Source = @"~/Content/images/WOMEN/Jeans/2_1.jpg", Alt ="Jeans"},
                    new ProductPhoto {Photo_id = 61, Product_id =50, Source = @"~/Content/images/WOMEN/Jeans/3_1.jpg", Alt ="Jeans"},
                    new ProductPhoto {Photo_id = 62, Product_id =51, Source = @"~/Content/images/WOMEN/Jeans/4_1.jpg", Alt ="Jeans"},
                    new ProductPhoto {Photo_id = 63, Product_id =51, Source = @"~/Content/images/WOMEN/Jeans/5_1.jpg", Alt ="Jeans"},
                   new ProductPhoto {Photo_id = 64, Product_id =52, Source = @"~/Content/images/WOMEN/Shoes/Flats/1_1.jpg", Alt ="Shoes"},
                   new ProductPhoto {Photo_id = 65, Product_id =53, Source = @"~/Content/images/WOMEN/Shoes/Flats/2_1.jpg", Alt ="Shoes"},
                   new ProductPhoto {Photo_id = 66, Product_id =54, Source = @"~/Content/images/WOMEN/Shoes/Sneakers/1_1.jpg", Alt ="Shoes"},
                   new ProductPhoto {Photo_id = 67, Product_id =55, Source = @"~/Content/images/WOMEN/Shoes/Summer_shoes/1_1.jpg", Alt ="Shoes"},
                   new ProductPhoto {Photo_id = 68, Product_id =56, Source = @"~/Content/images/WOMEN/Shoes/Summer_shoes/2_1.jpg", Alt ="Shoes"},
                   new ProductPhoto {Photo_id = 69, Product_id =57, Source = @"~/Content/images/WOMEN/Skirts/Midi/1_1.jpg", Alt ="Skirts"},
                   new ProductPhoto {Photo_id = 70, Product_id =58, Source = @"~/Content/images/WOMEN/Skirts/Midi/2_1.jpg", Alt ="Skirts"},
                   new ProductPhoto {Photo_id = 71, Product_id =59, Source = @"~/Content/images/WOMEN/Skirts/Mini/1_1.jpg", Alt ="Skirts"},
                   new ProductPhoto {Photo_id = 72, Product_id =60, Source = @"~/Content/images/WOMEN/Skirts/Mini/2_1.jpg", Alt ="Skirts"},
                   new ProductPhoto {Photo_id = 73, Product_id =61, Source = @"~/Content/images/WOMEN/Skirts/Mini/3_1.jpg", Alt ="Skirts"},
                   new ProductPhoto {Photo_id = 74, Product_id =62, Source = @"~/Content/images/WOMEN/Swimwear/2_1.jpg", Alt ="Swimwear"},
                   new ProductPhoto {Photo_id = 75, Product_id =63, Source = @"~/Content/images/WOMEN/TShirts/Basic/1_1.jpg", Alt ="TShirt"},
                   new ProductPhoto {Photo_id = 76, Product_id =64, Source =  @"~/Content/images/WOMEN/TShirts/Basic/2_1.jpg", Alt ="TShirt"},
                   new ProductPhoto {Photo_id = 77, Product_id =65, Source =  @"~/Content/images/WOMEN/TShirts/Printed/2_1.jpg", Alt ="TShirt"},
                   new ProductPhoto {Photo_id = 78, Product_id =66, Source =  @"~/Content/images/WOMEN/TShirts/Sleeveless/1_1.jpg", Alt ="TShirt"},
                   new ProductPhoto {Photo_id = 79, Product_id =67, Source =  @"~/Content/images/WOMEN/TShirts/Sleeveless/3_1.jpg", Alt ="TShirt"},
                   new ProductPhoto {Photo_id = 80, Product_id =68, Source =  @"~/Content/images/WOMEN/Body/Plain/2_1.jpg", Alt ="Body"},
                   new ProductPhoto {Photo_id = 81, Product_id =69, Source =  @"~/Content/images/Kids/Boys/Accessories/Hats/1_1.jpg", Alt ="Hats"},
                   new ProductPhoto {Photo_id = 82, Product_id =70, Source =  @"~/Content/images/Kids/Boys/Accessories/Hats/1_2.jpg", Alt ="Hats"},
                   new ProductPhoto {Photo_id = 83, Product_id =71, Source =  @"~/Content/images/Kids/Boys/Accessories/Hats/1_3.jpg", Alt ="Hats"},
                   new ProductPhoto {Photo_id = 84, Product_id =72, Source = @"~/Content/images/Kids/Boys/Accessories/Hats/1_4.jpg", Alt ="Hats"},
                   new ProductPhoto {Photo_id = 85, Product_id =73, Source =  @"~/Content/images/Kids/Boys/Accessories/Hats/1_5.jpg", Alt ="Hats"},
                   new ProductPhoto {Photo_id = 86, Product_id =74, Source =  @"~/Content/images/Kids/Boys/Accessories/Jewellery/1_1.jpg", Alt ="Jewellery"},
                   new ProductPhoto {Photo_id = 87, Product_id =75, Source =  @"~/Content/images/Kids/Boys/Accessories/Jewellery/1_2.jpg", Alt ="Jewellery"},
                   new ProductPhoto {Photo_id = 88, Product_id =76, Source =  @"~/Content/images/Kids/Boys/Accessories/Jewellery/1_3.jpg", Alt ="Jewellery"},
                   new ProductPhoto {Photo_id = 89, Product_id =77, Source =  @"~/Content/images/Kids/Boys/Accessories/Jewellery/1_4.jpg", Alt ="Jewellery"},
                   new ProductPhoto {Photo_id = 90, Product_id =78, Source =  @"~/Content/images/Kids/Boys/Accessories/Jewellery/1_5.jpg", Alt ="Jewellery"},
                   new ProductPhoto {Photo_id = 91, Product_id =79, Source =  @"~/Content/images/Kids/Boys/Accessories/Sunglasses/1_1.jpg", Alt ="Sunglasses"},
                   new ProductPhoto {Photo_id = 92, Product_id =80, Source =  @"~/Content/images/Kids/Boys/Accessories/Sunglasses/1_2.jpg", Alt ="Sunglasses"},
                   new ProductPhoto {Photo_id = 93, Product_id =81, Source =  @"~/Content/images/Kids/Boys/Accessories/Sunglasses/1_3.jpg", Alt ="Sunglasses"},
                   new ProductPhoto {Photo_id = 94, Product_id =82, Source =  @"~/Content/images/Kids/Boys/Accessories/Sunglasses/1_4.jpg", Alt ="Sunglasses"},
                   new ProductPhoto {Photo_id = 95, Product_id =83, Source =  @"~/Content/images/Kids/Boys/Accessories/Sunglasses/1_5.jpg", Alt ="Sunglasses"},
                   new ProductPhoto {Photo_id = 96, Product_id =84, Source =  @"~/Content/images/Kids/Boys/Jackets/1_1.jpg", Alt ="Jackets"},
                   new ProductPhoto {Photo_id = 97, Product_id =85, Source = @"~/Content/images/Kids/Boys/Jackets/1_2.jpg", Alt ="Jackets"},
                   new ProductPhoto {Photo_id = 98, Product_id =86, Source = @"~/Content/images/Kids/Boys/Jackets/1_3.jpg", Alt ="Jackets"},
                   new ProductPhoto {Photo_id = 99, Product_id =87, Source = @"~/Content/images/Kids/Boys/Jackets/1_4.jpg", Alt ="Jackets"},
                   new ProductPhoto {Photo_id = 100, Product_id =88, Source = @"~/Content/images/Kids/Boys/Jackets/1_5.jpg", Alt ="Jackets"},
                   new ProductPhoto {Photo_id = 101, Product_id =89, Source = @"~/Content/images/Kids/Boys/Jeans/1_1.jpg", Alt ="Jeans"},
                   new ProductPhoto {Photo_id = 102, Product_id =90, Source = @"~/Content/images/Kids/Boys/Jeans/1_2.jpg", Alt ="Jeans"},
                   new ProductPhoto {Photo_id = 103, Product_id =91, Source = @"~/Content/images/Kids/Boys/Jeans/1_3.jpg", Alt ="Jeans"},
                   new ProductPhoto {Photo_id = 104, Product_id =92, Source = @"~/Content/images/Kids/Boys/Jeans/1_4.jpg", Alt ="Jeans"},
                   new ProductPhoto {Photo_id = 105, Product_id =93, Source =@"~/Content/images/Kids/Boys/Jeans/1_5.jpg", Alt ="Jeans"},
                   new ProductPhoto {Photo_id = 106, Product_id =94, Source = @"~/Content/images/Kids/Boys/TShirts/1_1.jpg", Alt ="TShirt"},
                   new ProductPhoto {Photo_id = 107, Product_id =95, Source = @"~/Content/images/Kids/Boys/TShirts/1_2.jpg", Alt ="TShirt"},
                   new ProductPhoto {Photo_id = 108, Product_id =96, Source = @"~/Content/images/Kids/Boys/TShirts/1_3.jpg", Alt ="TShirt"},
                   new ProductPhoto {Photo_id = 109, Product_id =97, Source =@"~/Content/images/Kids/Boys/TShirts/1_4.jpg", Alt ="TShirt"},
                   new ProductPhoto {Photo_id = 110, Product_id =98, Source =@"~/Content/images/Kids/Boys/TShirts/1_5.jpg", Alt ="TShirt"},
                   new ProductPhoto {Photo_id = 111, Product_id =99, Source =@"~/Content/images/Kids/Boys/TShirts/1_6jpg", Alt ="TShirts"},
                   new ProductPhoto {Photo_id = 112, Product_id =100, Source = @"~/Content/images/Kids/Boys/Shoes/1_1.jpg", Alt ="Shoes"},
                   new ProductPhoto {Photo_id = 113, Product_id =101, Source = @"~/Content/images/Kids/Boys/Shoes/1_2.jpg", Alt ="Shoes"},
                   new ProductPhoto {Photo_id = 114, Product_id =102, Source =@"~/Content/images/Kids/Boys/Shoes/1_3.jpg", Alt ="Shoes"},
                   new ProductPhoto {Photo_id = 115, Product_id =103, Source =@"~/Content/images/Kids/Boys/Shoes/1_4.jpg", Alt ="Shoes"},
                   new ProductPhoto {Photo_id = 116, Product_id =104, Source =@"~/Content/images/Kids/Boys/Shoes/1_5.jpg", Alt ="Shoes"},
                   new ProductPhoto {Photo_id = 117, Product_id =105, Source = @"~/Content/images/Kids/Boys/Shorts/1_1.jpg", Alt ="Shorts"},
                   new ProductPhoto {Photo_id = 118, Product_id =106, Source = @"~/Content/images/Kids/Boys/Shorts/1_2.jpg", Alt ="Shorts"},
                   new ProductPhoto {Photo_id = 119, Product_id =107, Source = @"~/Content/images/Kids/Boys/Shorts/1_3.jpg", Alt ="Shorts"},
                   new ProductPhoto {Photo_id = 120, Product_id =108, Source = @"~/Content/images/Kids/Boys/Shorts/1_4.jpg", Alt ="Shorts"},
                   new ProductPhoto {Photo_id = 121, Product_id =109, Source = @"~/Content/images/Kids/Boys/Shorts/1_5.jpg", Alt ="Shorts"},
                   new ProductPhoto {Photo_id = 122, Product_id =110, Source = @"~/Content/images/Kids/Gils/Accessories/Sunglasses/1_1.jpg", Alt ="Accessories"},
                   new ProductPhoto {Photo_id = 123, Product_id =111, Source = @"~/Content/images/Kids/Gils/Accessories/Sunglasses/1_2.jpg", Alt ="Accessories"},
                   new ProductPhoto {Photo_id = 124, Product_id =112, Source = @"~/Content/images/Kids/Gils/Accessories/Sunglasses/1_3.jpg", Alt ="Accessories"},
                   new ProductPhoto {Photo_id = 125, Product_id =113, Source =@"~/Content/images/Kids/Gils/Accessories/Sunglasses/1_4.jpg", Alt ="Accessories"},
                   new ProductPhoto {Photo_id = 126, Product_id =114, Source =@"~/Content/images/Kids/Gils/Accessories/Sunglasses/1_5.jpg", Alt ="Accessories"},
                   new ProductPhoto {Photo_id = 127, Product_id =115, Source = @"~/Content/images/Kids/Gils/Accessories/Hats/1_1.jpg", Alt ="Hats"},
                   new ProductPhoto {Photo_id = 128, Product_id =116, Source =@"~/Content/images/Kids/Gils/Accessories/Hats/1_2.jpg", Alt ="Hats"},
                   new ProductPhoto {Photo_id = 129, Product_id =117, Source =@"~/Content/images/Kids/Gils/Accessories/Hats/1_3.jpg", Alt ="Hats"},
                   new ProductPhoto {Photo_id = 130, Product_id =118, Source = @"~/Content/images/Kids/Gils/Accessories/Hats/1_4.jpg", Alt ="Hats"},
                   new ProductPhoto {Photo_id = 131, Product_id =119, Source =@"~/Content/images/Kids/Gils/Accessories/Hats/1_5.jpg", Alt ="Hats"},
                   new ProductPhoto {Photo_id = 132, Product_id =120, Source = @"~/Content/images/Kids/Gils/Accessories/Jewellery/1_1.jpg", Alt ="Jewellery"},
                   new ProductPhoto {Photo_id = 133, Product_id =121, Source = @"~/Content/images/Kids/Gils/Accessories/Jewellery/1_2.jpg", Alt ="Jewellery"},
                   new ProductPhoto {Photo_id = 134, Product_id =122, Source = @"~/Content/images/Kids/Gils/Accessories/Jewellery/1_3.jpg", Alt ="Jewellery"},
                   new ProductPhoto {Photo_id = 135, Product_id =123, Source = @"~/Content/images/Kids/Gils/Accessories/Jewellery/1_5.jpg", Alt ="Jewellery"},
                   new ProductPhoto {Photo_id = 136, Product_id =124, Source = @"~/Content/images/Kids/Gils/Dresses/1_1.jpg", Alt ="Dresses"},
                   new ProductPhoto {Photo_id = 137, Product_id =125, Source = @"~/Content/images/Kids/Gils/Dresses/1_2.jpg", Alt ="Dresses"},
                   new ProductPhoto {Photo_id = 138, Product_id =126, Source = @"~/Content/images/Kids/Gils/Dresses/1_3.jpg", Alt ="Dresses"},
                   new ProductPhoto {Photo_id = 139, Product_id =127, Source =  @"~/Content/images/Kids/Gils/Dresses/1_4.jpg", Alt ="Dresses"},
                   new ProductPhoto {Photo_id = 140, Product_id =128, Source =  @"~/Content/images/Kids/Gils/Dresses/1_5.jpg", Alt ="Dresses"},
                   new ProductPhoto {Photo_id = 141, Product_id =129, Source = @"~/Content/images/Kids/Gils/Jackets/1_1.jpg", Alt ="Jackets"},
                   new ProductPhoto {Photo_id = 142, Product_id =130, Source = @"~/Content/images/Kids/Gils/Jackets/1_2.jpg", Alt ="Jackets"},
                   new ProductPhoto {Photo_id = 143, Product_id =131, Source = @"~/Content/images/Kids/Gils/Jackets/1_3.jpg", Alt ="Jackets"},
                   new ProductPhoto {Photo_id = 144, Product_id =132, Source =  @"~/Content/images/Kids/Gils/Jackets/1_4.jpg", Alt ="Jackets"},
                   new ProductPhoto {Photo_id = 145, Product_id =133, Source = @"~/Content/images/Kids/Gils/Jackets/1_5.jpg", Alt ="Jackets"},
                   new ProductPhoto {Photo_id = 146, Product_id =134, Source =  @"~/Content/images/Kids/Gils/Jeans/1_1.jpg", Alt ="Jeans"},
                   new ProductPhoto {Photo_id = 147, Product_id =135, Source = @"~/Content/images/Kids/Gils/Jeans/1_2.jpg", Alt ="Jeans"},
                   new ProductPhoto {Photo_id = 148, Product_id =136, Source = @"~/Content/images/Kids/Gils/Jeans/1_3.jpg", Alt ="Jeans"},
                   new ProductPhoto {Photo_id = 149, Product_id =137, Source =@"~/Content/images/Kids/Gils/Jeans/1_4.jpg", Alt ="Jeans"},
                   new ProductPhoto {Photo_id = 150, Product_id =138, Source = @"~/Content/images/Kids/Gils/Jeans/1_5.jpg", Alt ="Jeans"},
                   new ProductPhoto {Photo_id = 151, Product_id =139, Source =  @"~/Content/images/Kids/Gils/Shoes/1_1.jpg", Alt ="Shoes"},
                   new ProductPhoto {Photo_id = 152, Product_id =140, Source =  @"~/Content/images/Kids/Gils/Shoes/1_2.jpg", Alt ="Shoes"},
                   new ProductPhoto {Photo_id = 153, Product_id =141, Source =  @"~/Content/images/Kids/Gils/Shoes/1_3.jpg", Alt ="Shoes"},
                   new ProductPhoto {Photo_id = 154, Product_id =142, Source = @"~/Content/images/Kids/Gils/Shoes/1_4.jpg", Alt ="Shoes"},
                   new ProductPhoto {Photo_id = 155, Product_id =143, Source =  @"~/Content/images/Kids/Gils/Shoes/1_5.jpg", Alt ="Shoes"},
                   new ProductPhoto {Photo_id = 156, Product_id =144, Source =  @"~/Content/images/Kids/Gils/Skirts/1_1.jpg", Alt ="Skirts"},
                   new ProductPhoto {Photo_id = 157, Product_id =145, Source =  @"~/Content/images/Kids/Gils/Skirts/1_2.jpg", Alt ="Skirts"},
                   new ProductPhoto {Photo_id = 158, Product_id =146, Source =  @"~/Content/images/Kids/Gils/Skirts/1_3.jpg", Alt ="Skirts"},
                   new ProductPhoto {Photo_id = 159, Product_id =147, Source = @"~/Content/images/Kids/Gils/Skirts/1_4.jpg", Alt ="Skirts"},
                   new ProductPhoto {Photo_id = 160, Product_id =148, Source =  @"~/Content/images/Kids/Gils/Skirts/1_5.jpg", Alt ="Skirts"}
            };


        }
        public void Add(ProductPhoto productPhoto)
        {
            productPhotos.Add(productPhoto);
            productPhoto.Photo_id = productPhotos.Max(r => r.Photo_id) + 1;
        }

        public void Delete(int id)
        {
            var productPhoto = Get(id);
            if (productPhoto != null)
            {
                productPhotos.Remove(productPhoto);
            }
        }

        public ProductPhoto Get(int id)
        {
            return productPhotos.Single(p => p.Photo_id.Equals(id));
        }


        public IEnumerable<ProductPhoto> GetAll()
        {
            return productPhotos;
        }

        public void Update(ProductPhoto productPhoto)
        {
            var existing = Get(productPhoto.Photo_id);
            if (existing != null)
            {
                existing.Photo_id = productPhoto.Photo_id;

            }
        }

        public int GetId(ProductPhoto productPhoto)
        {
            return productPhoto.Photo_id;
        }

    }
}