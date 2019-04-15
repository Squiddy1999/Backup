$hashmap=@{} 
foreach($file in Get-ChildItem "brown\*[0-9]") { 
    echo "Reading $file" 
    (Get-Content $file) -replace '(\w*)/(\w*)',"`$1" > t1.txt 
    (Get-Content 't1.txt') -replace "'",'' > t2.txt 
    (Get-Content 't2.txt') -replace '\`','' > t3.txt 
    (Get-Content 't3.txt') -replace '\[','' > t4.txt 
    (Get-Content 't4.txt') -replace '\]','' > t5.txt 
    (Get-Content 't5.txt') -replace '\$','' > t6.txt 

    foreach($line in Get-Content 't6.txt') { 
        $line = $line.Trim() 
        if ($line.Length -gt 0) { 
            echo $line 
            foreach($word in $line.Split(" ")) { 
                if ($hashmap.containsKey($word)) { 
                    $hashmap[$word]+=1 
                } else { 
                    $hashmap[$word]=1 
                } 
            } 
        } 
    } 
	break
} 

foreach($word in $hashmap.Keys) { 
    echo $word $hashmap[$word]
} 