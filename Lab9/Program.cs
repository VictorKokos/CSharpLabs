using Lab9;

Set images = new Set();




Image kartinka1 = new Image();
kartinka1.SetInf("Девятый вал", 500, 600);

Image kartinka2 = new Image();
kartinka2.SetInf("Три медведя в лесу", 1000, 500);

Image kartinka3 = new Image();
kartinka3.SetInf("Девочка с персиком", 2000, 3000);

Image kartinka4 = new Image();
kartinka4.SetInf("Девочка с персиком", 2000, 3000);

images.Add(kartinka1);
images.Add(kartinka2);
images.Add(kartinka3);
images.Add(kartinka4);

images.ShowSet();


images.Remove(kartinka1);

images.ShowSet();

images.Search(2);
images.Search(1);
