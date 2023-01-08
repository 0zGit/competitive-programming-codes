/************************************
*			  LAB 6.1.5.16		    *	
*************************************/
#include <stdio.h>
#include <string.h>

int main()
{
	struct Person{
	    int id;
	    char name[30];
	};
	
	struct Person p[4];
	
	p[0].id = 0;
	strcpy(p[0].name, "Mary Smith");
	p[1].id = 1;
	strcpy(p[1].name, "James Johnson");
	p[2].id = 2;
	strcpy(p[2].name, "Patricia Williams");
	p[3].id = 3;
	strcpy(p[3].name, "John Brown");
	
	int i;
	for(i = 0; i<=3; i++){
	    printf("%s\n",p[i].name);
	}
	
	return 0;
}
/*$PAGE*/