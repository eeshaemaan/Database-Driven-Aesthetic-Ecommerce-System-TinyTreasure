create database if not exists SE_project;
use SE_project;

create Table User (
	userID int primary Key auto_increment,
    username varchar(30) unique,
    password varchar(30)
);

create Table Orders (
	orderID int primary Key auto_increment,
    userID int Unique,   -- to ensure "exactly one" relation 
    totalprice decimal(10,2),
    orderDate datetime default current_timestamp,
    foreign key (userID) references User (userID) on delete set null
);

alter table Orders
drop column totalprice;

create Table Category (
	C_ID int primary Key auto_increment,
    C_name varchar(20) unique
);

insert into category (C_name)
values ('plushie'),
	   ('Stationary'),
       ('trinkets');

create Table Product (
	prod_ID int primary Key auto_increment,
    prod_name varchar(255),
    category_ID int,
    prod_description varchar(500),
    price decimal (10,2),
    Quantity_inStock int,
    foreign key (category_ID) references Category (C_ID) on delete cascade
);

alter table Product
add constraint check_prod_price check (price >= 0);

drop table product;

INSERT INTO Product (prod_name, category_ID, prod_description, price, Quantity_inStock) VALUES
('Stitch Plushie', 1, 'Soft and cuddly Stitch plushie, perfect for gifting.', 2700.00, 15),
('Brown Cat', 1, 'Adorable brown cat plush, soft and fluffy.', 2500.00, 12),
('Barbie Wallet', 3, 'Pink Barbie-themed wallet with multiple compartments.', 1200.00, 20),
('Ghost Keychains', 3, 'Cute little ghost keychains, glow in the dark.', 700.00, 30),
('Icebear Mug', 3, 'Minimalist Icebear-themed ceramic mug.', 1000.00, 25),
('Pack of 6 Highlighters', 2, 'Set of pastel-colored highlighters.', 1200.00, 40),
('Pooh Plushie', 1, 'Soft Winnie the Pooh plushie, great for kids.', 2000.00, 18),
('Mood Plush', 1, 'Reversible mood plush, shows happy and sad faces.', 1100.00, 22),
('Capybara Plushie', 1, 'Capybara plush toy, soft and huggable.', 1400.00, 10),
('Cat Plushie', 1, 'Fluffy cat plush with cute expressions.', 2100.00, 14),
('Alien Plushie', 1, 'Soft alien-themed plushie with big eyes.', 1700.00, 16),
('Pastel Diaries', 2, 'Set of pastel-colored diaries for journaling.', 2000.00, 35),
('Mushroom Pouch', 2, 'Zipper pouch with a cute mushroom design.', 1000.00, 28),
('Bubble Teddy Pens', 2, 'Pack of bubble teddy bear pens, smooth ink.', 900.00, 50),
('Smooth Gel Pens', 2, 'Set of smooth-flowing gel pens.', 1200.00, 45),
('Watercolor Pens', 2, 'Watercolor brush pens for creative artwork.', 799.00, 38),
('Blue Stationary Holder', 2, 'Desk organizer with multiple compartments.', 1500.00, 20),
('Pink Heart Earrings', 3, 'Elegant pink heart-shaped earrings.', 950.00, 25),
('Hello Kitty Chain', 3, 'Cute Hello Kitty-themed keychain.', 200.00, 60),
('Pastel Pink Bag', 2, 'Trendy pastel pink shoulder bag.', 2999.00, 12);

INSERT INTO Product (prod_name, category_ID, prod_description, price, Quantity_inStock) VALUES
('Cute Plant Pot', 3, 'Mini plant pot with an adorable design.', 1000.00, 20),
('Flower Tray', 3, 'Decorative flower-shaped tray for organization.', 600.00, 15),
('Panda Keychain', 3, 'Small panda-themed keychain, soft and fluffy.', 400.00, 35);

UPDATE Product 
SET prod_description = 'Experience the magic of Stitch with this soft and cuddly plushie. Designed with lifelike details, it makes a perfect gift for fans of all ages.'
WHERE prod_name = 'Stitch Plushie';

UPDATE Product 
SET prod_description = 'Snuggle up with this adorable brown cat plushie, crafted for ultimate softness and charm. A delightful companion for cat lovers.'
WHERE prod_name = 'Brown Cat';

UPDATE Product 
SET prod_description = 'Carry your essentials in style with this pink Barbie-themed wallet. Designed with multiple compartments, it adds a touch of elegance to your everyday routine.'
WHERE prod_name = 'Barbie Wallet';

UPDATE Product 
SET prod_description = 'Light up the dark with these charming glow-in-the-dark ghost keychains. A perfect accessory for fans of cute and spooky designs.'
WHERE prod_name = 'Ghost Keychains';

UPDATE Product 
SET prod_description = 'Enjoy your favorite drinks in this minimalist Icebear-themed ceramic mug. A stylish and cozy addition to your mug collection.'
WHERE prod_name = 'Icebear Mug';

UPDATE Product 
SET prod_description = 'Brighten up your notes with this set of pastel-colored highlighters. Designed for smooth and vibrant marking.'
WHERE prod_name = 'Pack of 6 Highlighters';

UPDATE Product 
SET prod_description = 'Bring home the joy of Winnie the Pooh with this soft and huggable plushie. A perfect companion for fans of the classic character.'
WHERE prod_name = 'Pooh Plushie';

UPDATE Product 
SET prod_description = 'Express your feelings with this reversible mood plush, featuring happy and sad faces. A fun and interactive way to show emotions.'
WHERE prod_name = 'Mood Plush';

UPDATE Product 
SET prod_description = 'Cuddle up with this adorable Capybara plush toy, designed for ultimate softness and warmth.'
WHERE prod_name = 'Capybara Plushie';

UPDATE Product 
SET prod_description = 'This fluffy cat plushie with expressive eyes is the perfect snuggle buddy for cat lovers.'
WHERE prod_name = 'Cat Plushie';

UPDATE Product 
SET prod_description = 'Take home an out-of-this-world friend with this soft alien-themed plushie, featuring large adorable eyes.'
WHERE prod_name = 'Alien Plushie';

UPDATE Product 
SET prod_description = 'Capture your thoughts in these beautifully designed pastel-colored diaries, perfect for journaling and creativity.'
WHERE prod_name = 'Pastel Diaries';

UPDATE Product 
SET prod_description = 'Store your essentials in this cute mushroom-designed zipper pouch, adding a whimsical touch to your accessories.'
WHERE prod_name = 'Mushroom Pouch';

UPDATE Product 
SET prod_description = 'Write smoothly with these adorable bubble teddy bear pens, designed for comfort and style.'
WHERE prod_name = 'Bubble Teddy Pens';

UPDATE Product 
SET prod_description = 'Enhance your writing experience with these smooth-flowing gel pens, perfect for effortless creativity.'
WHERE prod_name = 'Smooth Gel Pens';

UPDATE Product 
SET prod_description = 'Create stunning artwork with these watercolor brush pens, offering rich colors and smooth blending.'
WHERE prod_name = 'Watercolor Pens';

UPDATE Product 
SET prod_description = 'Keep your desk tidy with this stylish blue stationery holder, featuring multiple compartments for organization.'
WHERE prod_name = 'Blue Stationary Holder';

UPDATE Product 
SET prod_description = 'Add a touch of elegance to your look with these beautifully crafted pink heart-shaped earrings.'
WHERE prod_name = 'Pink Heart Earrings';

UPDATE Product 
SET prod_description = 'Show off your love for Hello Kitty with this adorable and stylish keychain, a perfect collectible for fans.'
WHERE prod_name = 'Hello Kitty Chain';

UPDATE Product 
SET prod_description = 'Stay trendy with this pastel pink shoulder bag, designed for both fashion and function.'
WHERE prod_name = 'Pastel Pink Bag';

UPDATE Product 
SET prod_description = 'Add charm to your space with this mini plant pot, featuring a delightful and eye-catching design.'
WHERE prod_name = 'Cute Plant Pot';

UPDATE Product 
SET prod_description = 'Organize your essentials with this decorative flower-shaped tray, combining elegance with functionality.'
WHERE prod_name = 'Flower Tray';

UPDATE Product 
SET prod_description = 'Carry the cuteness of pandas everywhere with this soft and fluffy panda-themed keychain.'
WHERE prod_name = 'Panda Keychain';


-- for keyword searching
create table tags (
	tagID int primary key auto_increment,
    tagName varchar(255)
);

INSERT INTO tags (tagName) 
VALUES 
('Plushie'), 
('Cute'), 
('Soft'), 
('Stationary'), 
('Accessories'), 
('Keychain'), 
('Bag'), 
('Giftable'), 
('Trendy'), 
('Handmade'),
('Mug');

create table ProductTags (
	ID int primary key auto_increment,
	prod_ID int,
    tagID int,
    foreign key (prod_ID) references Product (prod_ID),
    foreign key (tagID) references tags (tagID)
);

INSERT INTO ProductTags (prod_ID, tagID) VALUES
-- Plushies
(1, 1), (1, 2), (1, 3), (1, 8),  -- Stitch Plushie
(2, 1), (2, 2), (2, 3), (2, 8),  -- Brown Cat
(7, 1), (7, 2), (7, 3), (7, 8),  -- Pooh Plushie
(8, 1), (8, 2), (8, 3), (8, 8),  -- Mood Plush
(9, 1), (9, 2), (9, 3), (9, 8),  -- Capybara Plushie
(10, 1), (10, 2), (10, 3), (10, 8),  -- Cat Plushie
(11, 1), (11, 2), (11, 3), (11, 8),  -- Alien Plushie

-- Stationary
(6, 4), (6, 8), -- Highlighters
(13, 4), (13, 8),  -- Mushroom Pouch
(14, 4), (14, 8), -- Bubble Teddy Pens
(15, 4), (15, 8), -- Smooth Gel Pens
(16, 4), (16, 8), -- Watercolor Pens
(12, 4), (12, 8), -- Pastel Diaries
(17, 4), (17, 8), -- Blue Stationary Holder

-- Accessories & Trinkets
(3, 5), (3, 8),  -- Barbie Wallet
(18, 5), (18, 8),  -- Pink Heart Earrings
(19, 6), (19, 8),  -- Hello Kitty Keychain
(4, 6), (4, 8),  -- Ghost Keychains
(5, 8), (5, 11),  -- Icebear Mug
(20, 7), (20, 8), (20, 9);  -- Pastel Pink Bag


-- SEARCH MECHANISM
-- INSERT INTO Tag (tagName) VALUES ('cute'), ('soft'), ('plush');
-- INSERT INTO ProductTag (prodID, tagID) 
-- VALUES (1, (SELECT tagID FROM Tag WHERE tagName = 'cute')),
   --    (1, (SELECT tagID FROM Tag WHERE tagName = 'soft'));

-- SELECT p.name, t.tagName
-- FROM Product p
-- JOIN ProductTag pt ON p.prodID = pt.prodID
-- JOIN Tag t ON pt.tagID = t.tagID
-- WHERE t.tagName = 'cute';


create table orderProducts (
	prodBought_ID int primary key auto_increment,
    orderID int,
    prod_ID int,
    prod_quantity int,
    totalPrice decimal(10,2),
    foreign key (orderID) references Orders (orderID),
    foreign key (prod_ID) references Product (prod_ID),
    constraint check_totalPrice check (totalPrice >= 0)
);

create table checkOutInfo (
	check_ID int primary key auto_increment,
    userID int,
    orderID int,
    name varchar(255),
    email varchar(255),
    address varchar(255),
    phone varchar(11),
    paymentMethod ENUM('Credit Card', 'COD'),
	foreign key (orderID) references Orders (orderID),
    foreign key (userID) references User (userID)
);


