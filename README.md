### Assignment1-PriyamDesai

This repo contains assignment 1 of Web Development 1 HTTP-5112

## Question 1
` 
GET http://localhost/api/AddTen/{id}
` 
- This API returns a integer with addition of 10
-  http://localhost/api/AddTen/6 -> 16

## Question 2
` 
GET http://localhost/api/Square/{id}
` 
- This API returns a integer with addition of 10
- Returns the square of the integer input {id}.
- http://localhost/api/Square/6 -> 36

## Question 3
` 
POST http://localhost/api/Greeting
` 
- Returns the string “Hello World!”
- localhost/Greeting -> Hello World!

## Question 4

` 
GET http://localhost/api/Greeting/{id}
` 
- Returns the string “Greetings to {id} people!” where id is an integer value.
- localhost/Greeting/3 -> Greetings to 3 people!


## Question 5

` 
GET http://localhost/api/NumberMachine/{id}
` 
- Create a method which has an input {id}, and applies four mathematical operations to it.
- http://localhost:56522/api/numbermachine/36 -> - <ArrayOfstring>
                                                           <string>Two added to 36 : 38</string>
                                                           <string> Two substracted from 36 : 34</string>
                                                           <string>Two multiplicate to 36 : 72</string>
                                                          <string>36 divided by Two: 18</string>
                                                 </ArrayOfstring> 


## Question 6

` 
GET http://localhost/api/NumberMachine/{id}
` 

- You are charging your client $5.50 / FN (fortnight = 14 days) for web hosting and maintenance,plus an additional 13% HST. The input {id} represents the number of days which has elapsedsince the beginning of the hosting. Output 3 strings which describe the total hosting cost.
- http://localhost:56522/api/HostingCost/16 -> - <ArrayOfstring>
<string>2 fortnights at $5.50/FN = $11 CAD</string>
<string>HST 13% = $1.43 CAD</string>
<string>Total = $12.43 CAD</string>
</ArrayOfstring>


