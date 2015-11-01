jsonPWrapper ({
  "Features": [
    {
      "RelativeFolder": "FuzzBuzzTransformation.feature",
      "Feature": {
        "Name": "Fizz Buzz Transformation",
        "Description": "As a bad maths student, \r\nI need to obtain a specified list of sequence numbers where any number divisible by 3 use \r\n\"Fizz\" and any number divisible by 5 use \"Buzz\", \r\nso that I can avoid embarrassment in front of the whole class.",
        "FeatureElements": [
          {
            "Examples": [
              {
                "Name": "",
                "Description": "",
                "TableArgument": {
                  "HeaderRow": [
                    "input"
                  ],
                  "DataRows": [
                    [
                      "0"
                    ],
                    [
                      ""
                    ]
                  ]
                }
              }
            ],
            "Name": "Quit Application on empty input or zero",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I prompted to enter the total number of sequence numbers"
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I have entered in \"<input>\""
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "should exit application"
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          },
          {
            "Name": "Input a non numeric value",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I prompted to enter the total number of sequence numbers"
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I have entered in \"x\""
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should display \"Error : Need to enter a number\""
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I should prompted to enter another sequence number"
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Examples": [
              {
                "Name": "",
                "Description": "",
                "TableArgument": {
                  "HeaderRow": [
                    "input",
                    "output"
                  ],
                  "DataRows": [
                    [
                      "1",
                      "1"
                    ],
                    [
                      "5",
                      "1,2,Fizz,4,Buzz"
                    ],
                    [
                      "15",
                      "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz"
                    ]
                  ]
                }
              }
            ],
            "Name": "Input sequence number greater than 0",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I prompted to enter the total number of sequence numbers"
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I have entered in \"<input>\""
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should display \"<output>\""
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I should prompted to enter another sequence number"
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          }
        ],
        "Result": {
          "WasExecuted": false,
          "WasSuccessful": false
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": false,
        "WasSuccessful": false
      }
    }
  ],
  "Configuration": {
    "GeneratedOn": "17 October 2015 21:33:34"
  }
});