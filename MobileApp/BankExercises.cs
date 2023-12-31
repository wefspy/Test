﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MobileApp
{
    public class BankExercises
    {
        private readonly SQLiteConnection basicExercises;
        private readonly SQLiteConnection warmUp;
        private readonly SQLiteConnection coolDown;

        public BankExercises(string pathBasEx, string pathWarmUp, string pathCoolDown, bool flag)
        {

            basicExercises = new SQLiteConnection(pathBasEx);
            basicExercises.CreateTable<CardExercise>();

            warmUp = new SQLiteConnection(pathWarmUp);
            warmUp.CreateTable<CardExercise>();

            coolDown = new SQLiteConnection(pathCoolDown);
            coolDown.CreateTable<CardExercise>();

            if (flag) CreateBank();
        }

        public List<CardExercise> GetBasicExercisesByType(PartBody partBody)
        {
            return basicExercises.Table<CardExercise>()
                .Where(exercise => exercise.PartBody == partBody)
                .ToList();
        }

        public CardExercise GetBasicExercise(int id)
        {
            return basicExercises.Find<CardExercise>(id);
        }

        public List<CardExercise> GetWarmUp()
        {
            return warmUp.Table<CardExercise>()
                .ToList();
        }

        public CardExercise GetWarnUpExercise(int id)
        {
            return warmUp.Find<CardExercise>(id);
        }

        public List<CardExercise> GetCoolDown()
        {
            return coolDown.Table<CardExercise>()
                .ToList();
        }
        public CardExercise GetCoolDownExercise(int id)
        {
            return coolDown.Find<CardExercise>(id);
        }

        private void CreateBank()
        {
            var basicExercises = new List<CardExercise>() {
                new CardExercise(){ Name = "Классические отжимания", GIF="classicPushUps", Description="Встаньте в упор лежа, вытягивая тело в струнку. Убедитесь, что находитесь в удобном, устойчивом положении. Поставьте руки немного шире плеч. Теперь согните руки в локтях, опускаясь в отжимание, при этом локти направляйте назад", PartBody = PartBody.Hands},
                new CardExercise(){ Name = "Отжимания с узкой постановкой рук", GIF="pushUpsWithNarrowArms", Description="Приняв положение лежа, разведите руки чуть уже плеч. Выполняя отжимание, локти смотрят назад, грудь в нижней фазе почти касается пола. С усилием отожмитесь, возвращаясь в исходную позицию.", PartBody = PartBody.Hands},
                new CardExercise(){ Name = "Планка на прямых руках", GIF = "straightArmPlank", Description = "Примите позицию планки на вытянутых руках, удерживая вес тела только на ладонях и носках. Смотрите четко перед собой, напрягайте спину, ягодицы и пресс. Количество секунд увеличивайте по мере роста физических показателей.", PartBody = PartBody.Hands},
                new CardExercise(){ Name = "Подъем на бицепс сидя", GIF = "sittingBicepCurl", Description = "Сядьте, расставив ноги по обе стороны стула. Взяв снаряд в руку, зафиксируйте ее локтем на поверхности бедра. Опускайте вес, не допуская полного защелкивания суставного замка в локте. Подъем осуществляется до уровня плеча, соблюдая небольшие паузы в пиковых точках для максимизации напряжения.", PartBody = PartBody.Hands},
                new CardExercise(){ Name = "Приседание с подъемом колена", GIF = "squatWithKneeLift", Description = "Поставьте ноги немного шире плеч, руки сложите перед собой. Выполните классическое приседание до параллели с полом, а на подъеме поднимите одно колено вверх, опуская руки синхронно вниз. Снова сделайте приседание и на следующем подъеме поднимите вверх колено другой ноги.", PartBody = PartBody.Legs},
                new CardExercise(){ Name = "Выпады вперед", GIF = "forwardLunges", Description = "Встаньте прямо, ноги на ширине плеч, руки положите на талию. Сделайте широкий шаг вперед, перенося на переднюю ногу вес тела. Согните ноги в коленях, опускаясь в выпад. Вернитесь обратно и повторите другой ногой. Старайтесь выполнять движения от бедер и ягодиц, а не от поясницы, чтобы как следует нагрузить мышцы ног.", PartBody = PartBody.Legs},
                new CardExercise(){ Name = "Выпады назад", GIF = "lungesBack", Description = "Встаньте прямо, ноги на ширине плеч, руки положите на пояс. Сделайте широкий шаг назад и согните ноги в коленях, опускаясь в выпад. Перенесите вес тела на переднюю ногу и вернитесь в исходное положение. Повторите выпад назад другой ногой. Старайтесь выполнять выпады не от поясницы, а от бедер и ягодиц.", PartBody = PartBody.Legs},
                new CardExercise(){ Name = "Приседание с подъемом на носки", GIF = "squatWithCalfRaise", Description = "Поставьте ноги шире плеч и опуститесь в приседание. В нижней точке поднимитесь на носки, затем опустите пятки и поднимитесь из приседа. При подъеме снова поднимитесь на носки, затем сделайте присед и повторите все сначала.", PartBody = PartBody.Legs},
                new CardExercise(){ Name = "Скручивания", GIF = "basicCrunches", Description = "Лягте на спину, заведите руки за голову и согните ноги в коленях. Теперь оторвите от пола голову и лопатки, скручиваясь в корпусе. Следите, чтобы поясница, таз и стопы были плотно прижаты к полу. Выполняйте скручивания с максимальной амплитудой до ощущения жжения в верхней части пресса.", PartBody = PartBody.Press },
                new CardExercise(){ Name = "Подъем корпуса с руками вперед", GIF = "raisingBodyWithArmsForward", Description = "Лягте на спину, ноги согните в коленях, при этом прямые руки заведите за голову. Теперь оторвите руки и корпус от пола, скручиваясь к коленям и стараясь руками коснуться стоп. Затем вернитесь в исходное положение и повторите все сначала.", PartBody = PartBody.Press},
                new CardExercise(){ Name = "Подъем корпуса с руками вперед", GIF = "cruncheWithArmExtension", Description = "Лежа на спине, поднимите ноги, не разгибая их в коленях. Выпрямите руки и заведите их за голову. Разведите руки в стороны, одновременно отрывая лопатки от пола, как в классических скручиваниях. Коснитесь руками коленей и снова разведите руки через стороны, возвращаясь в исходное положение.", PartBody = PartBody.Press},
                new CardExercise(){ Name = "Приведение колена в планке", GIF = "adductionKneeInPlank", Description = "Встаньте в планку на прямых руках, ладони ровно под плечевыми суставами, тело вытянуто в одну линию. Согните правую ногу в колене и приведите колено к груди. Возвращаясь в исходное положение, не ставьте ногу на пол, а согните ее в колене и снова выполните приведение. Не забудьте повторить для другой ноги.", PartBody = PartBody.Press},
                new CardExercise(){ Name = "Жим гантелей", GIF = "dumbbellPress", Description = "Работа ведется лежа на специальной скамье. Изначально вес можно возложить на грудь, после чего повернуть гантели в продольный хват, будто удерживаете гриф. Далее выжимайте вес перед собой, стараясь удерживать снаряды по одной линии без перекосов.", PartBody = PartBody.Chest},
                new CardExercise(){ Name = "Разведение гантелей", GIF = "breedingDumbbells", Description = "Приняв положение лежа на спине, поднимите вес перед собой на руках, слегка согнутых в локтях. Зафиксируйте их, после чего медленно разводите вес в стороны, добиваясь ощущения растяжения в грудных мышцах. Слишком низко гантели опускать не нужно, чтобы снизить травмоопасность упражнения.", PartBody = PartBody.Chest},
                new CardExercise(){ Name = "Лодочка", GIF = "boat", Description="Лягте на живот, руки лежат вдоль тела, ноги опираются на носки. Немного приподнимите голову и руки – это исходное положение. Теперь максимально поднимите вверх голову, грудь и ноги, опираясь на таз и живот. Спустя пару секунд вернитесь в начальную позицию и снова повторите упражнение.", PartBody = PartBody.Back},
                new CardExercise(){ Name = "Отжимания \"щучкой\"", GIF = "pikePushUps", Description = "Встаньте в собаку мордой вниз, для этого из упора лежа поднимите таз вверх, выпрямляя ноги и руки. Голову не опускайте слишком низко, чтобы было удобно выполнять отжимания. Согните руки в локтях под углом 90 градусов, не сгибая ноги в коленях. Спина должна быть прямая, переносите вес тело на руки и грудные мышцы.", PartBody = PartBody.Back},
                new CardExercise(){ Name = "Тяга гантелей с опорой на скамью", GIF = "benchDumbbellRow", Description = "Упритесь ладонью в поверхность скамейки. Свободная рука удерживает гантель, корпус опустите до параллели с полом. Тяга выполняется до уровня груди, после чего осуществляется маленькая пауза и вес опускается в стартовую фазу.", PartBody = PartBody.Back},
                new CardExercise(){ Name = "Параллельный жим гантелей над головой", GIF = "overheadDumbbellParallelPress", Description = "Сядьте на стул/скамью с прямой спиной, взяв снаряды молотковым хватом по высоте подбородка. Разгибайте руки над собой, соблюдая параллельное расположение гантелей. Вновь верните стартовую фазу, сделав задержку в пиковой амплитуде. Можно выполнять как стоя, так и сидя.", PartBody = PartBody.Back}
            };
            foreach (var exercise in basicExercises)
                this.basicExercises.Insert(exercise);

            var warmUp = new List<CardExercise>() {
                new CardExercise() { Name = "Вращения головой из стороны в сторону", GIF = "headRotationFromSideToSide", Description = "Примите положение обычной стойки, стопы установите на ширину плеч. Спину распрямите, смотрите вперед, а руки уберите на талию. Наклоните голову влево почти до плеча, начните делать вращение вперед – доведите до прямой позиции подбородок, касаясь верхней части груди, а потом перенесите голову на правую сторону.", PartBody = PartBody.None},
                new CardExercise() { Name = "Поочередные вращения", GIF = "alternateRotationsInShoulderJoints", Description = "Опустите правую руку вниз, левой обхватите корпус или держите свободно. Начинайте вращение правой рукой в плечевом суставе медленно с полной амплитудой, заводя руку далеко назад и максимально вперед. Затем повторите другой рукой.", PartBody = PartBody.None},
                new CardExercise() { Name = "Вращения плечами", GIF = "shoulderRotation", Description = "Элемент разминки перед тренировкой выполняется стоя. Опустите руки, после чего начните совершать медленные и глубокие вращения плеч назад. Взгляд направьте четко перед собой. Работа ведется исключительно за счет силы дельтовидных мышц и трапеций. Повторите тоже самое с вращениями вперед.", PartBody = PartBody.None},
                new CardExercise() { Name = "Вращения предплечий", GIF = "forearmRotations", Description = "Локтевой сустав чаще остальных подвергается травмам. Чтобы размять его, примите Т-образную позу, согните руки и направьте локти в разные друг от друга стороны. После этого начните медленно вращать предплечья внутрь, избегая резких движений.", PartBody = PartBody.None},
                new CardExercise() { Name = "Вращения кистями", GIF = "brushRotations", Description = "Слегка согнув руки в локтях, начните выполнять вращения кулаков, что позволит разогреть кистевой сустав и подготовить ладони к удержанию внушительных весов без риска травмирования.", PartBody = PartBody.None},
                new CardExercise() { Name = "Вращения корпуса", GIF = "bodyRotation", Description = "Для начала зафиксируйте руки на поясе, ноги на ширине плеч. Начните делать вращения верхней частью тела, чередуя направления движения.", PartBody = PartBody.None},
                new CardExercise() { Name = "Вращения головой", GIF = "rotationInHipJoints", Description = "Подальше, чем на ширину плеч, удалите стопы друг от друга. Поверните слегка по сторонам носки. Выпрямитесь, руки расположите на талию. Теперь сделайте круговые вращения в тазобедренных суставах – отодвиньте таз влево, потом по максимальной окружности вперед, вправо и назад.", PartBody = PartBody.None},
                new CardExercise() { Name = "Махи вперед-назад у опоры", GIF = "swingBackAndForthAtSupport", Description = "Встаньте сбоку от опоры (например, стул или стена). Одну руку расположите на опору, другую на пояс. В умеренном темпе начните делать мах дальней от опоры ноги вперед и назад до уровня таза. Носок чуть натяните на себя, колено слегка подогните.", PartBody = PartBody.None},
                new CardExercise() { Name = "Подтягивание бедра к груди", GIF = "pullHipToChest", Description = "Расставьте стопы на ширину плеч, туловище держите ровно. Начните медленно поднимать ногу, согнутую в коленном суставе, к груди. Обхватите на уровне таза ее руками, подтяните сильнее. Ощутите натяжение в бицепсе бедра. Это же повторите с другой ногой.", PartBody = PartBody.None},
                new CardExercise() { Name = "Подтягивание голени к ягодицам", GIF = "pullingLowerLegToButtocks", Description = "Расставьте стопы на ширину плеч, туловище держите ровно. Начните медленно поднимать ногу, согнутую в коленном суставе, к груди. Обхватите на уровне таза ее руками, подтяните сильнее. Ощутите натяжение в бицепсе бедра. Это же повторите с другой ногой.", PartBody = PartBody.None},
                new CardExercise() { Name = "Имитация прыжков со скакалкой", GIF = "imitationJumpingRope", Description = "Примите стойку как для прыжков со скакалкой – стопы чуть расставлены, руки согнуты в локтях, кисти отведены в стороны. Прыгайте на месте, отталкиваясь двумя ногами. Представьте, что вы делаете это со скакалкой и начните вращать немного руками. Пружиньте в коленях, не держите их выпрямленными.", PartBody = PartBody.None}
            };
            foreach (var exercise in warmUp)
                this.warmUp.Insert(exercise);

            var coolDown = new List<CardExercise>() {
                new CardExercise() { Name = "Вытяжение рук вверх над головой", GIF = "stretchingYourArmsUpOverYourHead", Description = "Останьтесь стоять, ноги удалены на ширину плеч, тело расслаблено. Направьте взгляд вперед. Теперь сцепите кисти перед собой в замок, протяните руки вверх над головой, выпрямите в локтях, разверните ладони. Корпус ровный, нельзя по сторонам его отклонять. Потянитесь еще сильнее вверх.", PartBody = PartBody.None},
                new CardExercise() { Name = "Растяжка трицепсов", GIF = "tricepsStretch", Description = "Это упражнение аналогично тому, что делается перед тренировкой, только в заминке его можно выполнять в статике. Согнутую в локте руку нужно завести за голову. Натяжение усиливается за счет работы свободной руки, которая слегка поддавливает на локоть рабочей.", PartBody = PartBody.None},
                new CardExercise() { Name = "Отведение рук в стороны", GIF = "pullingHandsToSide", Description = "Вытяните правую руку перед собой, распрямив пальцы ладони. Теперь медленно отводите ее в противоположную сторону, усиливая натяжение за счет давления свободной руки на локоть растягиваемой.", PartBody = PartBody.None},
                new CardExercise() { Name = "Растягивание предплечий и кистей", GIF = "stretchingForearmsAndHands", Description = "Выпрямите правую руку перед собой так, чтобы ладонь оказалась повернута к потолку. После этого согните кисть вниз. Усиливайте растяжку за счет натяжения пальцев при помощи левой руки. Уделив определенное время для растяжки предплечий и кистей, поменяйте сторону.", PartBody = PartBody.None},
                new CardExercise() { Name = "Растягивание грудных мышц от стены", GIF = "stretchingChestMusclesFromWall", Description = "Начальная задача — упереться правой ладонью в стену. Конечность при этом вытянута, а левая рука стоит на поясе. Сделайте шаг вперед, чтобы зафиксированная ладонь оказалась позади. Прижимайтесь к стене, чтобы усилить натяжение грудной мышцы и рук.", PartBody = PartBody.None},
                new CardExercise() { Name = "Прогиб в спине назад", GIF = "backBendBack", Description = "Поставив руки на пояс, аккуратно начинайте прогибаться в пояснице назад. Не наклоняйтесь слишком быстро, поскольку спина является весьма уязвимым к растяжению местом. Зафиксируйтесь в принятой позиции на несколько секунд, не закидывая сильно голову назад, после чего вернитесь обратно.", PartBody = PartBody.None},
                new CardExercise() { Name = "Растяжка с поворотом корпуса", GIF = "bodyRotationStretch", Description = "Повернитесь, присядьте на коврик, протяните и сомкните ноги. Распрямите при этом спину. Теперь перешагните правой ногой через левую, поставьте эту стопу на пол сбоку от коленки. Развернитесь корпусом вправо, левый локоть на бедро переставленной ноги, а правую руку заведите за спину, пальцы на коврик.", PartBody = PartBody.None},
                new CardExercise() { Name = "Растяжка квадрицепса лежа на животе", GIF = "stretchingQuadricepsLyingOnStomach", Description = "Лягте на живот, вытяните позвоночник в прямую линию, а лбом упритесь в пол (коврик). Поднимите одну голень наверх, когда доведете до перпендикуляра, схватите ее за голеностоп руками. Притяните максимально к ягодицам.", PartBody = PartBody.None},
                new CardExercise() { Name = "Растяжка ягодиц лежа", GIF = "lyingButtockStretch", Description = "Лягте на живот, вытяните позвоночник в прямую линию, а лбом упритесь в пол (коврик). Поднимите одну голень наверх, когда доведете до перпендикуляра, схватите ее за голеностоп руками. Притяните максимально к ягодицам.", PartBody = PartBody.None},
                new CardExercise() { Name = "Поза ребенка", GIF = "childPose", Description = "Расположитесь на коленях, а ягодицами сядьте на пятки. Нагнитесь вперед так, чтобы туловище разместить на бедрах. Руки распрямите, вытяните перед собой, ладони положите на пол. Смотрите вниз. Расслабьтесь и ощутите натяжение и в мышцах, и в спине.", PartBody = PartBody.None}
            };
            foreach (var exercise in coolDown)
                this.coolDown.Insert(exercise);
        }
    }
}
