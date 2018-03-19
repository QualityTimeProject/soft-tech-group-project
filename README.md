# soft-tech-group-project
Software Technologies repository (group project)

# Who is who details:

- Vladimir Georgiev - Member 1 (Team Leader) and Member 5,
- Kristian Dimitrov/ Aleksandar Dimitrov - Member 2,
- Aleksandar Dimitrov - Member 3,
- Yanka Georgieva/ Vladimir Georgiev - Member 4;

# Description of homework exercises:

## Problem 1. Debit Card Number

Write a program, which receives **4 integers** on the console and **prints them** in **4-digit debit card format**. See the examples below for the appropriate formatting.

### Examples

<table>
  <tr>
    <td><strong>Input</strong></td>
    <td><strong>Output</strong></td>
  </tr>
  <tr>
    <td>12</td>
	<td rowspan="4" valign="top">0012 0433 0001 5331</td>
  </tr>
  <tr>
    <td>433</td>
  </tr>
  <tr>
    <td>1</td>
  </tr>
  <tr>
    <td>5331</td>
  </tr>  
  <tr>
    <td>9182</td>
	<td rowspan="4" valign="top">9182 4221 0012 0003</td>
  </tr>
  <tr>
    <td>4221</td>
  </tr>
  <tr>
    <td>12</td>
  </tr>
  <tr>
    <td>3</td>
  </tr>
  <tr>
    <td>812</td>
	<td rowspan="4" valign="top">0812 0321 0123 0022</td>
  </tr>
  <tr>
    <td>321</td>
  </tr>
  <tr>
    <td>123</td>
  </tr>
  <tr>
    <td>22</td>
  </tr>
</table>

## Problem 2. Rectangle Area

Write a program, which calculates a **rectangle&#39;s area**, based on its **width** and **height**. The **width** and **height** come as floating point numbers on the console, **formatted to the 2<sup>nd</sup> character after the decimal point**.

### Examples

<table>
  <tr>
    <td><strong>Input</strong></td>
	<td><strong>Output</strong></td>
  </tr>
  <tr>
    <td>2</td>
	<td rowspan="2" valign="top">14.00</td>
  </tr>
  <tr>
    <td>7</td>
  </tr>
  <tr>
    <td>7</td>
	<td rowspan="2" valign="top">56.00</td>
  </tr>
  <tr>
	<td>8</td>
  </tr>
  <tr>
    <td>12.33</td>
	<td rowspan="2" valign="top">61.65</td>
  </tr>
  <tr>
	<td>5</td>
  </tr>
 </table>

## Problem 3. Miles to Kilometers

Write a program, which **converts miles** to **kilometers**. **Format** the output to the **2<sup>nd</sup> decimal place**.

Note: **1 mile == 1.60934 kilometers**

### Examples

<table style="border: 0px solid black; border-color: none; background-color: none;">
  <tr>
    <td>
	  <table style="float: left;">
		<tr>
		  <td><strong>Input</strong></td>
		  <td><strong>Output</strong></td>
		</tr>
		<tr>
		  <td>60</td>
		  <td>96.56</td>
		</tr>
	  </table>
    </td>
	<td>
	  <table style="float: middle;">
		<tr>
		  <td><strong>Input</strong></td>
		  <td><strong>Output</strong></td>
		</tr>
		<tr>
		  <td>1</td>
		  <td>1.61</td>
		</tr>
	  </table>
	</td>
  	<td>
	  <table style="float: right;">
		<tr>
		  <td><strong>Input</strong></td>
		  <td><strong>Output</strong></td>
		</tr>
		<tr>
		  <td>52.1113</td>
		  <td>83.86</td>
		</tr>
	  </table>
	</td>
</table>


## Problem 5.  * Character Stats

Write a program, which **displays information** about a video game character. You will receive
their **name**, **current health**, **maximum
health**, **current energy** and **maximum energy **on separate lines. The **current** values will **always** be valid (**equal or lower** than their respective **max** values). Print them in the format as per the examples.

### Examples

<table style="border: none;">
<tr>
<td>
<table style="float: left;">
<tr>
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
<tr>
<td>
Mayro
<br>5
<br>10
<br>9
<br>10
</td>
<td>
<br>Name: Mayro
<br>Health: ||||||.....|
<br>Energy: ||||||||||.|  	
</td>
</tr>
</table>			
</td>
<td>
<table style="float: right;">
<tr>
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
<tr>
<td>
Bauser
<br>10
<br>10
<br>10
<br>10
</td>
<td>
Name: Bauser
<br>Health: ||||||||||||
<br>Energy: ||||||||||||
</td>
</tr>
</table>
</td>
</tr>
</table>

<table style="border: none;">
<tr>
<td>
<table style="float: left;">
<tr>
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
<tr>
<td>
Loogi
<br>8
<br>20
<br>2
<br>14
</td>
<td>
<br>Name: Loogi
<br>Health: |||||||||............|
<br>Energy: |||............|	
</td>
</tr>
</table>
</td>
<td>
<table style="float: right;">
<tr>
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
<tr>
<td>
Toad
<br>0
<br>5
<br>0
<br>10
</td>
<td>
Name: Toad
<br>Health: |.....|
<br>Energy: |..........|
</td>
</tr>
</table>
</td>
</tr>
</table>


### Hints

· You can print a character **multiple** times, using new string(character, count).
