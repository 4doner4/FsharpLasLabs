open System.Windows.Forms
open System
open System.IO
open System.Drawing

/// Task 1 reversmap ///

//let f1 = new Form(Text= "AAAAAAA")

//let t1 = new TextBox(Text = "", Top = 30)

//let butn = new Button(Text = "+", Top = 80);

//let btnClickHandler (sender: obj) (e: EventArgs): unit =
//    let array = t1.Text.ToCharArray()

//    let reverseArray = [| for i = array.Length - 1 downto 0 do
//                              array[i]|]

//    t1.Text <-  (reverseArray |> Seq.map string |> String.concat "")


//butn.Click.AddHandler(btnClickHandler)


//f1.Controls.Add(t1);

//f1.Controls.Add(butn);

//Application.Run(f1);

/// Task 2 posledEl ///


//let f1 = new Form(Text= "AAAAAAA")

//let t1 = new TextBox(Text = "", Top = 30)
//let t2 = new TextBox(Text = "", Top = 50)
//let t3 = new TextBox(Text = "", Top = 00)

//let butn = new Button(Text = "+", Top = 80);

//f1.Controls.Add(t1);
//f1.Controls.Add(t2);
//f1.Controls.Add(t3);

//f1.Controls.Add(butn);

//let btnClickHandler (sender: obj) (e: EventArgs): unit =
//    let array1 = t1.Text.ToCharArray()

//    let array2= t2.Text.ToCharArray();

//    let array3 = Array.append array1 [|array2[array2.Length - 1]|]

//    t3.Text <- (array3 |> Seq.map string |> String.concat ",")


//butn.Click.AddHandler(btnClickHandler)



//Application.Run(f1);

/// Task 3 concat arr ///


//let f1 = new Form(Text= "AAAAAAA")

//let t1 = new TextBox(Text = "", Top = 30)
//let t2 = new TextBox(Text = "", Top = 50)
//let t3 = new TextBox(Text = "", Top = 00)

//let butn = new Button(Text = "+", Top = 80);

//f1.Controls.Add(t1);
//f1.Controls.Add(t2);
//f1.Controls.Add(t3);

//f1.Controls.Add(butn);

//let btnClickHandler (sender: obj) (e: EventArgs): unit =
//    let array1 = t1.Text.ToCharArray()

//    let array2= t2.Text.ToCharArray();

//    let array3 = Array.append array1 array2

//    t3.Text <- (array3 |> Seq.map string |> String.concat ",")


//butn.Click.AddHandler(btnClickHandler)



//Application.Run(f1);

/// Task 4 delen na 3 ///


//let f1 = new Form(Text= "AAAAAAA")

//let t2 = new TextBox(Text = "", Top = 50)

//let butn = new Button(Text = "+", Top = 80);

//f1.Controls.Add(t2);

//f1.Controls.Add(butn);

//let btnClickHandler (sender: obj) (e: EventArgs): unit =
//    let array1 = [1..12];

//    let array2= [|for item in array1 do
//                            if (not(item % 3 <> 0))
//                            then
//                                item|]

  

//    t2.Text <- (array2 |> Seq.map string |> String.concat ",")


//butn.Click.AddHandler(btnClickHandler)

//Application.Run(f1);

/// Task 5 raznost 2 el ///

//let f1 = new Form(Text= "AAAAAAA")

//let t1 = new TextBox(Text = "", Top = 10)
//let t2 = new TextBox(Text = "", Top = 30)
//let t3 = new TextBox(Text = "", Top = 50)


//let butn = new Button(Text = "+", Top = 80);

//f1.Controls.Add(t1);
//f1.Controls.Add(t2);
//f1.Controls.Add(t3);

//f1.Controls.Add(butn);

//let btnClickHandler (sender: obj) (e: EventArgs): unit =
//    let array1 = t1.Text.ToCharArray();
//    let array2= t2.Text.ToCharArray();
//    let mutable array3 = [||];
//    for el = 0 to array1.Length-1 do
//        let tmp = string(int(array1[el]) - int(array2[el]));
//        array3 <- Array.append array3 [|tmp|];

//    t3.Text <- (array3 |> Seq.map string |> String.concat ",")


//butn.Click.AddHandler(btnClickHandler)

//Application.Run(f1);

/// Task 6 soedinenie massivov///


let f1 = new Form(Text= "AAAAAAA")

let t1 = new TextBox(Text = "", Top = 10)
let t2 = new TextBox(Text = "", Top = 30)
let t3 = new TextBox(Text = "", Top = 50)


let butn = new Button(Text = "+", Top = 80);

f1.Controls.Add(t1);
f1.Controls.Add(t2);
f1.Controls.Add(t3);

f1.Controls.Add(butn);

let btnClickHandler (sender: obj) (e: EventArgs): unit =
    let array1 = t1.Text.ToCharArray();
    let array2= t2.Text.ToCharArray();
    let mutable array3 = [||];

    let mutable flag = true;

    for i = 0 to array1.Length - 1 do
        flag <- true        
        for j = 0 to array2.Length - 1 do
            if (array1[i] = array2[j] && flag = true)
            then
                array3 <- Array.append array3 [|array2[i]|]
                flag <- false



    t3.Text <- (array3 |> Seq.map string |> String.concat ",")


butn.Click.AddHandler(btnClickHandler)

Application.Run(f1);


