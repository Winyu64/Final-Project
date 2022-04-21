# Final-Project
ความเป็นมาของโปรแกรม
```
โปรแกรมนี้เกิดจากคิดไอเดียที่จะทำ โปรแกรมบันทึกการขาย เพราะทางบ้านของผม ครอบครัวทำอาชีพขายกับข้าวหน้าบ้าน ผมจึงได้เอาเมนูต่างๆมาใส่ในโปรแกรม โปรแกรมบันทึกการขายจะช่วยให้นับยอดการขายได้ง่ายขึ้น ผมจะพัฒนาโปรแกรมไปเรื่อยๆให้ที่บ้านได้มีโปรแกรมดีๆได้ใช่ครับ ขอบคุณครับ
วัตถุประสงค์ของโปรแกรม
```
วัตถุประสงค์ของโปรแกรมนี้สร้างขึ้นเพื่อที่จะบันทึกว่ามีการขายข้าว-น้ำได้เท่าไหร่ในเเต่ละวัน

```
Class Diagram
```mermaid
classDiagram
 direction LR
 class form1{
 -Loging()
 -Logout()
 }
 class form2{
 -ok()void
 -Exit()void
 goform3()
 goform4()
 }
 class form3{
 -file()void
 -charge()void
 -delete()void
 -calculate()void
 -sell()void
 -back()void
 -checkBox1
 -checkBox2
 -checkBox3
 -checkBox4
 -checkBox5
 -checkBox6
 -numericUpDown1
 -numericUpDown2
 -numericUpDown3
 -numericUpDown4
 -numericUpDown5
 -numericUpDown6
 open()
 save()
 charge()
 delete()
 calculate()
 sell()
 backform2()
 }
 

 class form4{
 -file()void
 -charge()void
 -delete()void
 -calculate()void
 -sell()void
 -back()void
 -checkBox1
 -checkBox2
 -checkBox3
 -checkBox4
 -numericUpDown1
 -numericUpDown2
 -numericUpDown3
 -numericUpDown4
 open()
 save()
 charge()
 delete()
 calculate()
 sell()
 backform2()
 }
 form3 --|> form2
 form4 --|> form2
 form2 --|> form1
```
เจ้าของโปรแกรม
```นาย วิญญู พรมภิภักดิ์```
