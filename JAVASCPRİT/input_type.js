

function deger(deger1) {
    var sonuc=0;
    var sayı1=document.getElementById("inp1").value;
    var sayı2=document.getElementById("inp2").value;

  switch (deger1) {
    case "+":sonuc= Number(sayı1)+Number(sayı2); break;
    case "-":sonuc=sayı1-sayı2; break;
    case "*":sonuc=sayı1*sayı2; break;
    case "/":sonuc=sayı1/sayı2; break;
        default: break;
  }

  //nenelerin için eklemeden sonra temizleyelim
  inp1.value = "";
  inp2.value = "";
  document.getElementById("sonucc").innerHTML="Sonuç : "+sonuc;
  //temizlemeden sonra ad içine odaklansın
  inp1.focus();
}
