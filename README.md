# soft-tech-group-project
Software Technologies repository (group project)

# Who is who details:

- Vladimir Georgiev - Member 1 (Team Leader) and Member 5,
- Kristian Dimitrov - Member 2,
- Aleksandar Dimitrov - Member 3,
- Yanka Georgieva - Member 4;

# Description of homework exercises:

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


### Problem 5.  * Character Stats

Write a program, which **displays information** about a video game character. You will receive
their **name**, **current health**, **maximum
health**, **current energy** and **maximum energy **on separate lines. The **current** values will **always** be valid (**equal or lower** than their respective **max** values). Print them in the format as per the examples.

#### Examples


<table style="float: left;">
<tr>
<td><strong>Input</strong></td>
<td><strong>Output</strong></td>
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


<table style="float: right;">
<tr>
<td><strong>Input</strong></td>
<td><strong>Output</strong></td>
</tr>
<tr>
<td>
Bauser
<br>10
<br>10
<br>10
<br>10
/td>
<td>
Name: Bauser
<br>Health: ||||||||||||
<br>Energy: ||||||||||||
</td>
</tr>
</table>



#### Hints

· You can print a character **multiple** times, using new string(character, count).