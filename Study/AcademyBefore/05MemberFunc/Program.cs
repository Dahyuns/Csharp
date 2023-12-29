using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//< 총정리 >
// RPG를 만든다 -> 프로젝트
// 주인공이 있다. -> 클래스
// 주인공이 공격력이 있다. -> 멤버변수
// 주인공이 공격력으로 때린다. -> 멤버함수

//행동에 대해서 설명해 보세요
// 지형에서 달린다.
// 몬스터를 공격한다.
// NPC와 대화한다.
// 스킬을 사용한다.


class Player
{
    // 명사만으로는 부족하기때문에
    int ATT;
    int HP;

    // 행동으로 나타나게 된다.
    // 이런것을 표현하는것이 멤버함수
    // 굉장히 다양한 방법으로 함수를 선언할 수 있지만
    
    /*리턴값*/void /*리턴값*/Move /*인자값*/() /*변수와 이름이 같아선 안된다 */
    {// <- 함수의 시작
    }// <- 함수의 끝

    void Fight()
    {

    }

    void Attack()
    {

    }

    void Talk()
    {

    }

    void SkillUse()
    {

    }
}